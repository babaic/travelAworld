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
    }
}
