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

        public frmAddLokacija()
        {
            InitializeComponent();
        }

        private async void btnSaveForm_Click(object sender, EventArgs e)
        {
            LokacijaToAdd lokacija = new LokacijaToAdd
            {
                Mjesto = txtMjesto.Text,
                Drzava = txtDrzava.Text
            };

            await _addLokacija.Insert<dynamic>(lokacija);

            //this.Hide();
            this.Close();
        }
    }
}
