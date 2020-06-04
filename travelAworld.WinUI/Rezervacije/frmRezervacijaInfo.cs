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
        private int _id;
        public frmRezervacijaInfo(int id)
        {
            InitializeComponent();
            _id = id;
            loadData();

        }

        private async void loadData()
        {
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
    }
}
