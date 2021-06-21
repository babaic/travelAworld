using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using travelAworld.Model;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;


namespace travelAworld.WinUI.Rezervacije
{
    public partial class frmListaRezervacija : Form
    {
        private readonly APIService _getPonude = new APIService("ponuda/getponude");
        private readonly APIService _getPonudeUsers = new APIService("ponuda/getponudeusers");
        private int index = 0;

        public frmListaRezervacija()
        {
            InitializeComponent();

            var ponude = _getPonude.Get<PageResult<PonudaToDisplay>>(null);
            ponude.Items.Add(new PonudaToDisplay { Naslov = "Sve", PonudaId = 0 });

            pretragaPonuda.DisplayMember = "Naslov";
            pretragaPonuda.ValueMember = "PonudaId";
            pretragaPonuda.DataSource = ponude.Items;


            index = ponude.Count;

            pretragaPonuda.SelectedIndex = index;

            txtPageCounter.Text = 1.ToString();
        }
 
        private void frmListaRezervacija_Load(object sender, EventArgs e)
        {
            pretragaRezervacija(sender, e);
        }

        private void pretragaRezervacija(object sender, EventArgs e)
        {
            if (pretragaPonuda.SelectedIndex == index)
            {
                btnPosaljiObavijest.Enabled = false;
            }
            else
            {
                btnPosaljiObavijest.Enabled = true;
            }


            PonudaUserToSearch queryParams = new PonudaUserToSearch
            {
                PonudaId = Int32.Parse(pretragaPonuda.SelectedValue.ToString()),
                Datum = pretragaDatum.Value,
                PageNumber = Int32.Parse(txtPageCounter.Text)
            };

            var result = _getPonudeUsers.Get<PageResult<PonudaUserDisplay>>(queryParams);


            txtUkupno.Text = result.Count.ToString();

            var totalPages = (int)Math.Ceiling((double)result.Count / 10);

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            if (txtPageCounter.Text == "1")
            {
                btnPrevious.Enabled = false;
            }
            if (txtPageCounter.Text == totalPages.ToString())
            {
                btnNext.Enabled = false;
            }

            dgvPonudeUsers.DataSource = result.Items;
            dgvPonudeUsers.Columns["PonudaId"].HeaderText = "ID ponude";
            dgvPonudeUsers.Columns["NazivPonuda"].HeaderText = "Naziv ponude";
            dgvPonudeUsers.Columns["ImePrezime"].HeaderText = "Korisnik";
            dgvPonudeUsers.Columns["TransakcijaId"].HeaderText = "ID transakcije";
            dgvPonudeUsers.Columns["VrijemePlacanja"].HeaderText = "Datum uplate";
            dgvPonudeUsers.Columns["TipSobe"].HeaderText = "Tip sobe";
            dgvPonudeUsers.Columns["BrojOsoba"].HeaderText = "Broj osoba";
            dgvPonudeUsers.Columns["Jmbg"].Visible = false;
            dgvPonudeUsers.Columns["DatumRodjenja"].Visible = false;
            dgvPonudeUsers.Columns["Id"].Visible = false;
            dgvPonudeUsers.Columns["DatumPolaska"].Visible = false;

        }
        private void dgvPonudeUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dgvPonudeUsers.SelectedRows[0].Cells[0].Value;
            frmRezervacijaInfo frm = new frmRezervacijaInfo(Int32.Parse(id.ToString()));
            frm.Show();
        }

        private void btnPosaljiObavijest_Click(object sender, EventArgs e)
        {
            var ponudaId = Int32.Parse(pretragaPonuda.SelectedValue.ToString());
            var naslov = pretragaPonuda.Text;
            frmPosaljiObavijest frm = new frmPosaljiObavijest(ponudaId, naslov);
            frm.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var tempCount = txtPageCounter.Text;
            txtPageCounter.Text = (Int32.Parse(tempCount) + 1).ToString();
            this.pretragaRezervacija(sender, e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var tempCount = txtPageCounter.Text;
            txtPageCounter.Text = (Int32.Parse(tempCount) - 1).ToString();
            this.pretragaRezervacija(sender, e);
        }

        private void pretragaPonuda_SelectedIndexChanged(object sender, EventArgs e)
        {
            pretragaRezervacija(sender, e);
        }

        private void datumChanged(object sender, EventArgs e)
        {
            pretragaRezervacija(sender, e);
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            PonudaUserToSearch queryParams = new PonudaUserToSearch
            {
                PonudaId = Int32.Parse(pretragaPonuda.SelectedValue.ToString()),
                Datum = pretragaDatum.Value,
                PageSize = 5000
            };

            var result = _getPonudeUsers.Get<PageResult<PonudaUserDisplay>>(queryParams);

            //Create a new PDF document
            using (PdfDocument doc = new PdfDocument())
            {
                //Add a page to the document
                PdfPage page = doc.Pages.Add();

                //Create a PdfGrid.
                PdfGrid pdfGrid = new PdfGrid();

                //Create PDF graphics for a page
                PdfGraphics graphics = page.Graphics;

                //Set the standard font
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

                //Draw the text
                graphics.DrawString("Rezervacije za mjesec "+ prikaziMjesec(result.Items[0].DatumPolaska.Month), font, PdfBrushes.Black, new PointF(10, 0));


                //Create a DataTable.
                DataTable dataTable = new DataTable();
                //Add columns to the DataTable
                dataTable.Columns.Add("#");
                dataTable.Columns.Add("ID rezervacije");
                dataTable.Columns.Add("Naziv ponude");
                dataTable.Columns.Add("Ime i prezime putnika");
                dataTable.Columns.Add("Uplaćeno");
                dataTable.Columns.Add("Datum uplate");
                dataTable.Columns.Add("Tip sobe");
                dataTable.Columns.Add("Broj osoba");
                dataTable.Columns.Add("Kontakt telefon");
                //Add rows to the DataTable.
                int index = 1;
                foreach(var rezervacija in result.Items)
                {
                    dataTable.Rows.Add(new object[] { index, rezervacija.Id, rezervacija.NazivPonuda, rezervacija.ImePrezime, rezervacija.Cijena+" KM", rezervacija.VrijemePlacanja.ToShortDateString(), rezervacija.TipSobe, rezervacija.BrojOsoba, rezervacija.Telefon != null ? rezervacija.Telefon : "-" });
                    index++;
                }

                //Assign data source.
                pdfGrid.DataSource = dataTable;
                //Draw grid to the page of PDF document.
                pdfGrid.Draw(page, new PointF(10, 10));
                //Save the document.
                doc.Save("Output.pdf");
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start("Output.pdf");

                    //Exit
                    Close();
                }
                catch (Win32Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Close();
                }
            }

            string prikaziMjesec(int mjesec)
            {
                string mjesecDisplay = null;
                switch(mjesec)
                {
                    case 1: mjesecDisplay = "januar"; break;
                    case 2: mjesecDisplay = "februar"; break;
                    case 3: mjesecDisplay = "mart"; break;
                    case 4: mjesecDisplay = "april"; break;
                    case 5: mjesecDisplay = "maj"; break;
                    case 6: mjesecDisplay = "juni"; break;
                    case 7: mjesecDisplay = "juli"; break;
                    case 8: mjesecDisplay = "august"; break;
                    case 9: mjesecDisplay = "septembar"; break;
                    case 10: mjesecDisplay = "oktobar"; break;
                    case 11: mjesecDisplay = "novembar"; break;
                    case 12: mjesecDisplay = "decembar"; break;
                    default: break;
                }
                return mjesecDisplay;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
