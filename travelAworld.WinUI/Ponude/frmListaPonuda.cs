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
    public partial class frmListaPonuda : Form
    {
        private readonly APIService _getNekretnina = new APIService("nekretnina/GetNekretnina");
        private readonly APIService _getGradovi = new APIService("nekretnina/GetGrad");
        private int index = 0;
        bool prikaziObrisanePonude = false;
        public frmListaPonuda()
        {
            InitializeComponent();

            var gradovi = _getGradovi.Get<List<GradToDisplayVM>>(null);
            gradovi.Add(new GradToDisplayVM { Naziv = "Bilo koji", GradId = 0 });

            pretragaGrad.DisplayMember = "Naziv";
            pretragaGrad.ValueMember = "GradId";
            pretragaGrad.DataSource = gradovi;

            index = gradovi.Count - 1;

            pretragaGrad.SelectedIndex = index;


            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.FlatStyle = FlatStyle.Flat;
            bcol.DefaultCellStyle.BackColor = Color.FromArgb(28, 49, 58);
            bcol.DefaultCellStyle.ForeColor = Color.White;
            bcol.HeaderText = "";
            bcol.Text = "Pregled";
            bcol.Name = "btnClickMe";
            bcol.UseColumnTextForButtonValue = true;
            dgvPonude.Columns.Add(bcol);

        }

        private void frmListaPonuda_Load(object sender, EventArgs e)
        {
            pretragaPonuda(sender, e);
        }

        private void pretragaPonuda(object sender, EventArgs e)
        {
            NekretninaToSearchVM queryParams = new NekretninaToSearchVM
            {
               GradId = Int32.Parse(pretragaGrad.SelectedValue.ToString()),
            };

            var result = _getNekretnina.Get<List<NekretninaToDisplayVM>>(queryParams);
            
            dgvPonude.DataSource = result;
            dgvPonude.Columns["Opis"].Visible = false;
            dgvPonude.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPonude.Columns["KategorijaNekretnina"].HeaderText = "Kategorija";
            dgvPonude.Columns["PosjedujeLift"].HeaderText = "Lift";
            dgvPonude.Columns["PosjedujeKlimu"].HeaderText = "Klima";
            dgvPonude.Columns["UkljuceneRezije"].HeaderText = "Uključene režije";
            dgvPonude.Columns["GodinaIzgradnje"].HeaderText = "Godina izgradnje";
            dgvPonude.Columns["BrojEtaza"].HeaderText = "Br. etaža";
            txtUkupno.Text = result.Count.ToString();

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
            pretragaGrad.SelectedIndex = index;
        }

        private void dgvPonude_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvPonude.SelectedRows[0].Cells[1].Value;
            frmAddEditPonuda frm = new frmAddEditPonuda(Int32.Parse(id.ToString()));
            frm.Show();
        }

        private void dgvPonude_CellCClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var id = dgvPonude.Rows[e.RowIndex].Cells[1].Value;
                frmAddEditPonuda frm = new frmAddEditPonuda(Int32.Parse(id.ToString()));
                frm.Show();
            }

        }

        private void ObrisaneShowHide(object sender, EventArgs e)
        {
            if (checkPrikaziIzbrisane.Checked)
            {
                prikaziObrisanePonude = true;
            }
            else
            {
                prikaziObrisanePonude = false;
            }
            pretragaPonuda(sender, e);
        }

    }
}
