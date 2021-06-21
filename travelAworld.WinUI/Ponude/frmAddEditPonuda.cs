using eRent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelAworld.Model;

namespace travelAworld.WinUI.Ponude
{
    public partial class frmAddEditPonuda : Form
    {
        private readonly APIService _getLokacija = new APIService("Nekretnina/GetGrad");
        private readonly APIService _dodajPonudu = new APIService("Nekretnina/nova");
        private readonly APIService _getKategorije = new APIService("Nekretnina/GetKategorije");
        private readonly APIService _getPonuda = new APIService("Nekretnina/GetNekretninaById");
        private readonly APIService _updatePonuda = new APIService("Nekretnina/updatenekretnina");

        private readonly APIService _getVodici = new APIService("ponuda/getvodici");
        private readonly APIService _obavijest = new APIService("ponuda/dodajobavijest");
        private readonly APIService _otkaziPonudu = new APIService("ponuda/otkaziponudu");
        bool locationAdded = false; //prevent loading x times same data
        NekretninaToDisplayVM ponudaEdit;

        List<int> izabraniVodici = new List<int>();

        private int? id = null;

        public frmAddEditPonuda(int? ponudaid = null)
        {
            InitializeComponent();

            id = ponudaid;
            if (id.HasValue)
            {
                this.formTitle.Text = "Uredi podatke ponude";
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }


            loadData();

            thumb1.ImageLocation = img1.Text;
            thumb2.ImageLocation = img2.Text;
            thumb3.ImageLocation = img3.Text;
            thumb4.ImageLocation = img4.Text;
            thumb5.ImageLocation = img5.Text;
            thumb6.ImageLocation = img6.Text;
        }

        private async void loadData()
        {

            var getLokacija = _getLokacija.Get<List<GradToDisplayVM>>(null);
            var getKategorija = _getKategorije.Get<List<KategorijaToDisplayVM>>(null);

            dropLokacija.ValueMember = "GradId";
            dropLokacija.DisplayMember = "Naziv";
            dropLokacija.DataSource = getLokacija;
            dropLokacija.SelectedIndex = dropLokacija.Items.Count-1;

            dropKategorija.ValueMember = "KategorijaId";
            dropKategorija.DisplayMember = "Naziv";
            dropKategorija.DataSource = getKategorija;
            dropKategorija.SelectedIndex = dropKategorija.Items.Count - 1;

            //edit
            if (id.HasValue)
            {
                //dropLokacija.Enabled = false;
                panelBrisiPonudu.Visible = true;

                ponudaEdit = await _getPonuda.GetById<NekretninaToDisplayVM>(id);

                //if (!ponudaEdit.IsActive)
                //{
                //    btnBrisiPonudu.Enabled = false;
                //    btnSaveForm.Enabled = false;
                //    lblObrisano.Visible = true;
                //}

                txtIme.Text = ponudaEdit.Naziv;
                rtxtOpis.Text = ponudaEdit.Opis;
                txtCijena.Text = ponudaEdit.Cijena.ToString();
                txtAdresa.Text = ponudaEdit.Adresa;
                txgGodina.Text = ponudaEdit.GodinaIzgradnje.ToString();
                txtSprat.Text = ponudaEdit.Sprat.ToString();
                txtBrojEtaza.Text = ponudaEdit.BrojEtaza.ToString();
                txtKvadratura.Text = ponudaEdit.Kvadratura.ToString();
                cbGrijanje.Checked = ponudaEdit.Grijanje == "DA" ? true : false;
                cbKlima.Checked = ponudaEdit.PosjedujeKlimu;
                cbLift.Checked = ponudaEdit.PosjedujeLift;
                cbRezije.Checked = ponudaEdit.UkljuceneRezije;

                {
                    img1.Enabled = false;
                    img2.Enabled = false;
                    img3.Enabled = false;
                    img4.Enabled = false;
                    img5.Enabled = false;
                    img6.Enabled = false;
                }
                dropLokacija.Text = ponudaEdit.Grad;
                dropKategorija.Text = ponudaEdit.KategorijaNekretnina;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddLokacija form = new frmAddLokacija();
            
            form.Show();
            form.FormClosed += delegate
            {
                locationAdded = true;
                loadData();
            };

        }

        private async void btnSaveForm_Click(object sender, EventArgs e)
        {
            if (!passValidation())
                return;

            
            List<string> slike = new List<string>();
            if (img1.TextLength > 5)
            {
                slike.Add(img1.Text);
            }
            if (img2.TextLength > 5)
            {
                slike.Add(img2.Text);
            }
            if (img3.TextLength > 5)
            {
                slike.Add(img3.Text);
            }
            if (img4.TextLength > 5)
            {
                slike.Add(img4.Text);
            }
            if (img5.TextLength > 5)
            {
                slike.Add(img5.Text);
            }
            if (img6.TextLength > 5)
            {
                slike.Add(img6.Text);
            }

            // add ponuda
            if (!id.HasValue)
            {
                NekretninaToAddVM ponuda = new NekretninaToAddVM
                {
                    Cijena = Int32.Parse(txtCijena.Text),
                    Naziv = txtIme.Text,
                    Opis = rtxtOpis.Text,
                    GradId = Int32.Parse(dropLokacija.SelectedValue.ToString()),
                    KategorijaNekretnineId = Int32.Parse(dropKategorija.SelectedValue.ToString()),
                    Adresa = txtAdresa.Text,
                    GodinaIzgradnje = Int32.Parse(txgGodina.Text),
                    Sprat = Int32.Parse(txtSprat.Text),
                    BrojEtaza = Int32.Parse(txtBrojEtaza.Text),
                    Kvadratura = Int32.Parse(txtKvadratura.Text),
                    Grijanje = cbGrijanje.Checked ? "DA" : "NE",
                    PosjedujeKlimu = cbKlima.Checked,
                    PosjedujeLift = cbLift.Checked,
                    UkljuceneRezije = cbRezije.Checked,
                    Slike = slike,
                };

                await _dodajPonudu.Insert<dynamic>(ponuda);
            }
            else
            {
                //edit
                NekretninaToAddVM nekretnina = new NekretninaToAddVM
                {
                    Cijena = Double.Parse(txtCijena.Text),
                    Naziv = txtIme.Text,
                    Opis = rtxtOpis.Text,
                    GradId = Int32.Parse(dropLokacija.SelectedValue.ToString()),
                    KategorijaNekretnineId = 1,
                    Adresa = txtAdresa.Text,
                    GodinaIzgradnje = Int32.Parse(txgGodina.Text),
                    Sprat = Int32.Parse(txtSprat.Text),
                    BrojEtaza = Int32.Parse(txtBrojEtaza.Text),
                    Kvadratura = Double.Parse(txtKvadratura.Text),
                    Grijanje = cbGrijanje.Checked ? "DA" : "NE",
                    PosjedujeKlimu = cbKlima.Checked,
                    PosjedujeLift = cbLift.Checked,
                    UkljuceneRezije = cbRezije.Checked,

                    //Slike = slike,
                };
                await _updatePonuda.Update<dynamic>(id.Value, nekretnina);

            }
            MessageBox.Show("Ponuda dodana", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private bool passValidation()
        {
            string poruka;

            if (string.IsNullOrEmpty(txtIme.Text))
            {
                showMsg("Naziv ponude je Obavezno polje");return false;
            }
            if (string.IsNullOrEmpty(rtxtOpis.Text))
            {
                showMsg("Opis je Obavezno polje");return false;
            }
            if (string.IsNullOrEmpty(txtCijena.Text))
            {
                showMsg("Cijena Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(img1.Text) && id == null)
            {
                showMsg("Slika 1 je Obavezno polje"); return false;
            }
            return true;
        }

        private void showMsg(string poruka)
        {
            MessageBox.Show(poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void displayImage(PictureBox pic, TextBox url)
        {
            if(url.TextLength > 5)
            {
                pic.ImageLocation = url.Text;
            }
        }

        private void img1_Validating(object sender, CancelEventArgs e)
        {
            displayImage(thumb1, img1);
        }

        private void img2_Validating(object sender, CancelEventArgs e)
        {
            displayImage(thumb2, img2);
        }

        private void img3_Validating(object sender, CancelEventArgs e)
        {
            displayImage(thumb3, img3);
        }

        private void img4_Validating(object sender, CancelEventArgs e)
        {
            displayImage(thumb4, img4);
        }

        private void img5_Validating(object sender, CancelEventArgs e)
        {
            displayImage(thumb5, img5);
        }

        private void img6_Validating(object sender, CancelEventArgs e)
        {
            displayImage(thumb6, img6);
        }

        private async void btnBrisiPonudu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati ponudu ? Poništit ćete sve rezervacije!", "Brisanje ponude", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                await _otkaziPonudu.Insert<dynamic>(new OtkaziPonudu { Id = id.Value });
                loadData();

            }
            else if (result == DialogResult.No)
            {
                //no...
            }
        }
    }
}
