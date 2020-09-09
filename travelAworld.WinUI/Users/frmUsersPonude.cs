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
using travelAworld.WinUI.Rezervacije;

namespace travelAworld.WinUI.Users
{
    public partial class frmUsersPonude : Form
    {
        private readonly APIService _getPutovanjaUser = new APIService("user/putovanjauser");
        public frmUsersPonude(int userid)
        {
            InitializeComponent();

            SearchUser userId = new SearchUser { Id = userid };

            var result = _getPutovanjaUser.Get<List<PutovanjeRezervacijaToDisplay>>(userId);

            dgvPutovanja.DataSource = result;
            dgvPutovanja.Columns["PonudaId"].HeaderText = "#ID Ponude";
            dgvPutovanja.Columns["rezervacijaId"].Visible = false;

            dgvPutovanja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvPutovanja.Columns["PonudaId"].HeaderText = "#ID";
            dgvPutovanja.Columns["DatumPolaska"].HeaderText = "Datum polaska";
            dgvPutovanja.Columns["DatumPovratka"].HeaderText = "Datum povratka";

            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.FlatStyle = FlatStyle.Flat;
            bcol.DefaultCellStyle.BackColor = Color.FromArgb(28, 49, 58);
            bcol.DefaultCellStyle.ForeColor = Color.White;
            bcol.HeaderText = "";
            bcol.Text = "Vidi rezervaciju";
            bcol.Name = "btnClickMe";
            bcol.UseColumnTextForButtonValue = true;
            dgvPutovanja.Columns.Add(bcol);

        }

        private void dgvPutovanjaCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var id = dgvPutovanja.Rows[e.RowIndex].Cells[8].Value;
                frmRezervacijaInfo frm = new frmRezervacijaInfo(Int32.Parse(id.ToString()));
                frm.Show();
            }
        }
    }
}
