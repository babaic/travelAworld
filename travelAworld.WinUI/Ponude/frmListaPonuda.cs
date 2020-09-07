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
    public partial class frmListaPonuda : Form
    {
        private readonly APIService _getPonuda = new APIService("ponuda/getponude");
        private readonly APIService _getDrzave = new APIService("ponuda/getdrzave");
        private int index = 0;
        public frmListaPonuda()
        {
            InitializeComponent();

            var drzave = _getDrzave.Get<List<LokacijaToDisplay>>(null);
            drzave.Add(new LokacijaToDisplay { Drzava = "Bilo koja", LokacijaId = 0 });

            pretragaDrzava.DisplayMember = "Drzava";
            pretragaDrzava.ValueMember = "LokacijaId";
            pretragaDrzava.DataSource = drzave;

            index = drzave.Count - 1;

            pretragaDrzava.SelectedIndex = index;

            txtPageCounter.Text = 1.ToString();

        }

        private void frmListaPonuda_Load(object sender, EventArgs e)
        {
            pretragaPonuda(sender, e);
        }

        private void pretragaPonuda(object sender, EventArgs e)
        {

            PonudaToSearch queryParams = new PonudaToSearch
            {
               LokacijaId = Int32.Parse(pretragaDrzava.SelectedValue.ToString()),
               Datum = pretragaDatum.Value,
               PageNumber = Int32.Parse(txtPageCounter.Text)
            };

            var result = _getPonuda.Get<PageResult<PonudaToDisplay>>(queryParams);
            

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

           
            dgvPonude.DataSource = result.Items;
            //hide from table
            dgvPonude.Columns["CijenaUkljuceno"].Visible = false;
            dgvPonude.Columns["CijenaIskljuceno"].Visible = false;
            dgvPonude.Columns["Opis"].Visible = false;
            dgvPonude.Columns["Napomena"].Visible = false;
            dgvPonude.Columns["DrzavaId"].Visible = false;
            dgvPonude.Columns["Koordinate1"].Visible = false;
            dgvPonude.Columns["Koordinate2"].Visible = false;
            dgvPonude.Columns["_Drzava"].Visible = false;
            dgvPonude.Columns["_Mjesto"].Visible = false;

            dgvPonude.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPonude.Columns["PonudaId"].HeaderText = "#ID";
            dgvPonude.Columns["PonudaId"].Width = 40;
            //dgvPonude.Columns["Naslov"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvPonude.Columns["Lokacija"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPonude.Columns["DatumPolaska"].HeaderText = "Datum polaska";
            dgvPonude.Columns["DatumPovratka"].HeaderText = "Datum povratka";
        }

        private void drzavaChanged(object sender, EventArgs e)
        {
            pretragaPonuda(sender, e);
        }

        private void datumChanged(object sender, EventArgs e)
        {
            pretragaPonuda(sender, e);
        }

        private void btnPretragaPonisti_Click(object sender, EventArgs e)
        {
            pretragaDrzava.SelectedIndex = index;
        }

        private void dgvPonude_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvPonude.SelectedRows[0].Cells[0].Value;
            frmAddEditPonuda frm = new frmAddEditPonuda(Int32.Parse(id.ToString()));
            frm.Show();
        }
    }
}
