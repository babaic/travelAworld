using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using travelAworld.Model;

namespace travelAworld.WinUI.Users
{
    public partial class frmUsers : Form
    {
        private readonly APIService _apiService = new APIService("user");

        public frmUsers()
        {
            InitializeComponent();
            txtPageCounter.Text = 1.ToString();

            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.FlatStyle = FlatStyle.Flat;
            bcol.DefaultCellStyle.BackColor = Color.FromArgb(28, 49, 58);
            bcol.DefaultCellStyle.ForeColor = Color.White;
            bcol.HeaderText = "Rezervacije";
            bcol.Text = "Vidi putovanja";
            bcol.Name = "btnClickMe";
            bcol.UseColumnTextForButtonValue = true;
            dgvUsers.Columns.Add(bcol);
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
            dgvUsers.Columns["Id"].Visible = false;
            dgvUsers.Columns["Role"].Visible = false;
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

        private void ucitajNext(object sender, EventArgs e)
        {
            var tempCount = txtPageCounter.Text;
            txtPageCounter.Text = (Int32.Parse(tempCount) + 1).ToString();
            this.pretragaKorisnika(sender, e);
        }

        private void ucitajPrevious(object sender, EventArgs e)
        {
            var tempCount = txtPageCounter.Text;
            txtPageCounter.Text = (Int32.Parse(tempCount) - 1).ToString();
            this.pretragaKorisnika(sender, e);
        }

        private void ponistiPretragu(object sender, EventArgs e)
        {
            txtPretragaIme.Text = txtPretragaPrezime.Text = null;
            txtPageCounter.Text = 1.ToString();
            this.pretragaKorisnika(sender, e);
        }

        private void imeKlik(object sender, EventArgs e)
        {
            txtPageCounter.Text = "1";
            this.pretragaKorisnika(sender, e);
        }

        private void prezimeKlik(object sender, EventArgs e)
        {
            txtPageCounter.Text = "1";
            this.pretragaKorisnika(sender, e);
        }

        private void dgvUsersCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var userid = dgvUsers.Rows[e.RowIndex].Cells[1].Value;
                frmUsersPonude frm = new frmUsersPonude(Int32.Parse(userid.ToString()));
                frm.Show();
            }
        }
    }
}
