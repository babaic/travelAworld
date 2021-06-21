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

namespace travelAworld.WinUI.Uposlenici
{
    public partial class frmPrebaciOglas : Form
    {
        private readonly APIService _getOglasi = new APIService("nekretnina/getnekretnina");
        private readonly APIService _uposlenici = new APIService("user");
        private readonly APIService _prebaciOglas = new APIService("nekretnina/prebaciOglas");
        private readonly int _userid;
        public frmPrebaciOglas(int userid)
        {
            InitializeComponent();
            _userid = userid;
        }

        private void frmPrebaciOglas_Load(object sender, EventArgs e)
        {
            var ponude = _getOglasi.Get<List<NekretninaToDisplayVM>>(new NekretninaToSearchVM { UserId = _userid });
            cbOglasi.DisplayMember = "Naziv";
            cbOglasi.ValueMember = "NekretninaId";
            cbOglasi.DataSource = ponude;

            UserToSearch queryParams = new UserToSearch
            {
                Role = "Uposlenik",
            };

            var uposlenici = _uposlenici.Get<PageResult<UsertoDisplay>>(queryParams);
            uposlenici.Items = uposlenici.Items.Where(x => x.Id != _userid).ToList();

            cbUposlenik.DisplayMember = "Username";
            cbUposlenik.ValueMember = "Id";
            cbUposlenik.DataSource = uposlenici.Items;

            if(uposlenici.Count <= 1)
            {
                button1.Enabled = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var oglas = new PrebaciOglasVM
            {
                OglasId = Int32.Parse(cbOglasi.SelectedValue.ToString()),
                UserId = Int32.Parse(cbUposlenik.SelectedValue.ToString())
            };

            await _prebaciOglas.Insert<dynamic>(oglas);
            MessageBox.Show("Oglas prebačen", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
