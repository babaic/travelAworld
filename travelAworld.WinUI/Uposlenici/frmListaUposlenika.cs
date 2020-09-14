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

namespace travelAworld.WinUI.Uposlenici
{
    public partial class frmListaUposlenika : Form
    {
        private readonly APIService _apiService = new APIService("user");
        private Helpers helpers = new Helpers();
        public frmListaUposlenika()
        {
            InitializeComponent();
            dropFunkcija.SelectedItem = "Bilo koja";
            txtPageCounter.Text = 1.ToString();
        }

        private void ponistiPretragu(object sender, EventArgs e)
        {
            txtPretragaIme.Text = txtPretragaPrezime.Text = null;
            txtPageCounter.Text = 1.ToString();
            dropFunkcija.SelectedItem = "Bilo koja";
            this.pretragaKorisnika(sender, e);
        }


        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.pretragaKorisnika(sender, e);
        }

        private void pretragaKorisnika(object sender, EventArgs e)
        {

            UserToSearch queryParams = new UserToSearch
            {
                Ime = txtPretragaIme.Text,
                Prezime = txtPretragaPrezime.Text,
                Role = dropFunkcija.Text,
                PageNumber = Int32.Parse(txtPageCounter.Text)
            };

            var result = _apiService.Get<PageResult<UsertoDisplay>>(queryParams);
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


            dgvUsers.DataSource = result.Items;
            dgvUsers.Columns["Email"].Visible = false;
            dgvUsers.Columns["DatumRodjenja"].Visible = false;
            dgvUsers.RowTemplate.Height = 100;
            for (int i = 0; i < dgvUsers.Columns.Count; i++)
            {
                if (dgvUsers.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvUsers.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvUsers.SelectedRows[0].Cells[0].Value;
            frmAddEditUposlenik frm = new frmAddEditUposlenik(Int32.Parse(id.ToString()));
            frm.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var tempCount = txtPageCounter.Text;
            txtPageCounter.Text = (Int32.Parse(tempCount) + 1).ToString();
            this.pretragaKorisnika(sender, e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var tempCount = txtPageCounter.Text;
            txtPageCounter.Text = (Int32.Parse(tempCount) - 1).ToString();
            this.pretragaKorisnika(sender, e);
        }
    }
}
