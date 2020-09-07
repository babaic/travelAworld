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
    public partial class frmAddLokacija : Form
    {
        private readonly APIService _addLokacija = new APIService("ponuda/dodajlokaciju");
        private readonly APIService _getDrzave = new APIService("ponuda/getdrzave");

        public frmAddLokacija()
        {
            InitializeComponent();

            var drzave = _getDrzave.Get<List<LokacijaToDisplay>>(null);

            dropDrzava.DisplayMember = "Drzava";
            dropDrzava.ValueMember = "DrzavaId";
            dropDrzava.DataSource = drzave;
        }

        private async void btnSaveForm_Click(object sender, EventArgs e)
        {
            LokacijaToAdd lokacija = new LokacijaToAdd
            {
                Mjesto = txtMjesto.Text,
                Drzava = dropDrzava.Text,
            };

            await _addLokacija.Insert<dynamic>(lokacija);

            //this.Hide();
            this.Close();
        }
    }
}
