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

namespace travelAworld.WinUI.Rezervacije
{
    public partial class frmRezervacijaInfo : Form
    {
        private readonly APIService _rezervacijaInfo = new APIService("user/getrezervacijainfo");
        private readonly APIService _otkaziRezervaciju = new APIService("ponuda/otkaziRezervaciju");
        private readonly APIService _updateDispute = new APIService("ponuda/DisputeUpdate");
        private readonly APIService _getDisputeInfo = new APIService("ponuda/getdisputeid");
        private int _id;
        private DisputeToDisplay disputeInfo;
        public frmRezervacijaInfo(int id)
        {
            InitializeComponent();
            _id = id;
            loadData();

        }

        private async void loadData()
        {
            disputeInfo = await _getDisputeInfo.GetById<DisputeToDisplay>(_id);
            var result = await _rezervacijaInfo.GetById<RezervacijaInfo>(_id);
            txtRezervacijaId.Text = "Rezervacija #" + _id;
            imePrezime.Text = result.User.Ime+" "+result.User.Prezime;
            datumRodjenja.Text = result.User.DatumRodjenja.ToShortDateString();
            adresa.Text = result.User.Adresa;
            email.Text = result.User.Email;
            tipSobe.Text = result.PonudaUser.TipSobe;
            brojOsoba.Text = result.PonudaUser.BrojOsoba.ToString();
            cijena.Text = result.PonudaUser.Cijena + " KM";
            datumPlacanja.Text = result.PonudaUser.VrijemePlacanja.ToString();
            datumOd.Text = result.DatumOd.ToShortDateString();
            datumDo.Text = result.DatumDo.ToShortDateString();
            nazivPonude.Text = result.PonudaUser.NazivPonuda;

            lblDatumZavrseno.Visible = false;

            if (result.PonudaUser.IsCanceled)
            {
                lbl_otkazana_header.Visible = true;
                panelInfoOtkazivanje.Visible = true;
                btnOtkaziRezervaciju.Text = "OTKAZANO";
                btnOtkaziRezervaciju.ForeColor = Color.White;
                btnOtkaziRezervaciju.Enabled = false;

                lblStatus.Text = disputeInfo.StatusDisputa == 0 ? "AKTIVAN" : "ZAVRŠENO";
                txtIznosPovrata.Text = disputeInfo.IznosPovrata.ToString();
                
                if(disputeInfo.StatusDisputa == StatusDisputa.Zavrseno)
                {
                    txtIznosPovrata.Enabled = false;
                    btnZavrsi.Text = "ZAVRŠENO";
                    btnZavrsi.Enabled = false;
                    lblStatus.ForeColor = Color.DarkRed;
                    lblDatumZavrseno.Visible = true;
                    lblDatumZavrseno.Text = disputeInfo.DatumZavrsetkaDisputa;
                }
            }
            else
            {
                lbl_otkazana_header.Visible = false;
                panelInfoOtkazivanje.Visible = false;
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            btnPrevious.Visible = false;
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            //Create a Bitmap of size same as that of the Form.
            btnPrevious.Visible = false;
            Graphics grp = this.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);

            //Copy screen area that that the Panel covers.
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            btnPrevious.Visible = true;
        }

        private async void btnOtkaziRezervaciju_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite poništiti rezervaciju ? Rezervacija se više neće moći aktivirati!", "Poništavanje rezervacije", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OtkaziRezervaciju rez = new OtkaziRezervaciju { RezervacijaId = _id };
                await _otkaziRezervaciju.Insert<dynamic>(rez);
                loadData();

            }
            else if (result == DialogResult.No)
            {
                //no...
            }
        }


        private async void btnZavrsi_Click(object sender, EventArgs e)
        {
            var dispute = new DisputeToDisplay
            {
                StatusDisputa = StatusDisputa.Zavrseno,
                IznosPovrata = Int32.Parse(txtIznosPovrata.Text),
            };
            await _updateDispute.Update<dynamic>(disputeInfo.Id, dispute);
            loadData();
        }
    }
}
