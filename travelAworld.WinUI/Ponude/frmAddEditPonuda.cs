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
        private readonly APIService _getLokacija = new APIService("ponuda/getlokacija");
        private readonly APIService _dodajPonudu = new APIService("ponuda/dodajponudu");
        private readonly APIService _updatePonuda = new APIService("ponuda/updateponuda");
        private readonly APIService _getPonuda = new APIService("ponuda/getponuda");
        private readonly APIService _getVodici = new APIService("ponuda/getvodici");
        private readonly APIService _obavijest = new APIService("ponuda/dodajobavijest");
        bool locationAdded = false; //prevent loading x times same data
        PonudaToDisplay ponudaEdit;

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

            var getLokacija = _getLokacija.Get<List<Model.LokacijaToDisplay>>(null);
            
            dropLokacija.ValueMember = "LokacijaId";
            dropLokacija.DisplayMember = "FullLokacija";
            dropLokacija.DataSource = getLokacija;
            dropLokacija.SelectedIndex = dropLokacija.Items.Count-1;


            checkedListVodici.DisplayMember = "Username";
            checkedListVodici.ValueMember = "Id";

            if (!locationAdded)
            {
                var getVodici = _getVodici.Get<List<UsertoDisplay>>(null);
                int index = 0;
                foreach (var i in getVodici)
                {
                    checkedListVodici.Items.Insert(index, new UsertoDisplay { Username = i.Ime + " " + i.Prezime, Id = i.Id });
                    index++;
                }
            }

            //edit
            if (id.HasValue)
            {
                //dropLokacija.Enabled = false;

                ponudaEdit = await _getPonuda.GetById<PonudaToDisplay>(id);
                txtIme.Text = ponudaEdit.Naslov;
                rtxtOpis.Text = ponudaEdit.Opis;
                dateDatumPolaska.Value = ponudaEdit.DatumPolaska;
                dateDatumPovratka.Value = ponudaEdit.DatumPovratka;
                txtCijena.Text = ponudaEdit.Cijena.ToString();
                rtxtCijenaUkljuceno.Text = ponudaEdit.CijenaUkljuceno;
                rtxtCijenaNijeUkljuceno.Text = ponudaEdit.CijenaIskljuceno;
                rtxtNapomene.Text = ponudaEdit.Napomena;
                txtHotel.Text = ponudaEdit.Hotel;
                txtKoordinate1.Text = ponudaEdit.Koordinate1;
                txtKoordinate2.Text = ponudaEdit.Koordinate2;
                {
                    img1.Enabled = false;
                    img2.Enabled = false;
                    img3.Enabled = false;
                    img4.Enabled = false;
                    img5.Enabled = false;
                    img6.Enabled = false;
                }
                

                for (var i = 0; i < checkedListVodici.Items.Count; i++)
                {
                    foreach (var vodic in ponudaEdit.Vodic)
                    {
                        if((checkedListVodici.Items[i] as UsertoDisplay).Id == vodic.Id)
                        {
                            checkedListVodici.SetItemChecked(i, true);
                        }
                    }
                }
                dropLokacija.Text = ponudaEdit.Lokacija;
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

            
            for (var i = 0; i < checkedListVodici.Items.Count; i++)
            {
                if (checkedListVodici.GetItemChecked(i))
                {
                    izabraniVodici.Add((checkedListVodici.Items[i] as UsertoDisplay).Id);
                }
            }

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

            if (!id.HasValue)
            {
                PonudaToAdd ponuda = new PonudaToAdd
                {
                    Cijena = Int32.Parse(txtCijena.Text),
                    CijenaIskljuceno = rtxtCijenaNijeUkljuceno.Text,
                    CijenaUkljuceno = rtxtCijenaUkljuceno.Text,
                    DatumPolaska = dateDatumPolaska.Value,
                    DatumPovratka = dateDatumPovratka.Value,
                    Hotel = txtHotel.Text,
                    Napomena = rtxtNapomene.Text,
                    Naslov = txtIme.Text,
                    Opis = rtxtOpis.Text,
                    LokacijaId = Int32.Parse(dropLokacija.SelectedValue.ToString()),
                    VodicId = izabraniVodici,
                    Slike = slike,
                    Koordinate1 = txtKoordinate1.Text,
                    Koordinate2 = txtKoordinate2.Text
                };

                await _dodajPonudu.Insert<dynamic>(ponuda);
            }
            else
            {
                //edit
                PonudaToAdd ponuda = new PonudaToAdd
                {
                    Cijena = Int32.Parse(txtCijena.Text),
                    CijenaIskljuceno = rtxtCijenaNijeUkljuceno.Text,
                    CijenaUkljuceno = rtxtCijenaUkljuceno.Text,
                    DatumPolaska = dateDatumPolaska.Value,
                    DatumPovratka = dateDatumPovratka.Value,
                    Hotel = txtHotel.Text,
                    Napomena = rtxtNapomene.Text,
                    Naslov = txtIme.Text,
                    Opis = rtxtOpis.Text,
                    LokacijaId = Int32.Parse(dropLokacija.SelectedValue.ToString()),
                    VodicId = izabraniVodici,
                    //Slike = slike,
                    Koordinate1 = txtKoordinate1.Text,
                    Koordinate2 = txtKoordinate2.Text
                };
                await _updatePonuda.Update<dynamic>(id.Value, ponuda);

                bool posaljiNotifikaciju = false;
                string msg = "Došlo je do promjene u putovanju: ";

                if(ponudaEdit.DatumPolaska != ponuda.DatumPolaska)
                {
                    posaljiNotifikaciju = true;
                    msg += " Promijenjen je Datum polaska na " + ponuda.DatumPolaska;
                }
                if (ponudaEdit.DatumPovratka != ponuda.DatumPovratka)
                {
                    posaljiNotifikaciju = true;
                    msg += " Promijenjen je Datum povratka na " + ponuda.DatumPolaska;
                }
                if (ponudaEdit.Hotel != ponuda.Hotel)
                {
                    posaljiNotifikaciju = true;
                    msg += " Promijenjen je Hotel - " + ponuda.Hotel;
                }
                if (ponudaEdit.Napomena != ponuda.Napomena)
                {
                    posaljiNotifikaciju = true;
                    msg += " N A P O M E N A: " + ponuda.Napomena;
                }

                if (posaljiNotifikaciju)
                {
                    var obavijest = new ObavijestAdd
                    {
                        PonudaId = id.Value,
                        Tekst = msg,
                        Type = "notifikacija"
                    };

                    await _obavijest.Insert<object>(obavijest);
                }

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
            if (string.IsNullOrEmpty(rtxtCijenaNijeUkljuceno.Text))
            {
                showMsg("Cijena nije uključeno je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(rtxtCijenaUkljuceno.Text))
            {
                showMsg("Cijena uključeno je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(txtHotel.Text))
            {
                showMsg("Naziv hotela je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(txtKoordinate1.Text))
            {
                showMsg("Koordinate 1 je Obavezno polje"); return false;
            }
            if (string.IsNullOrEmpty(txtKoordinate2.Text))
            {
                showMsg("Koordinate 2 je Obavezno polje"); return false;
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

        
    }
}
