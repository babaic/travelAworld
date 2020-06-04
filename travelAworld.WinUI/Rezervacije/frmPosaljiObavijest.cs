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
    public partial class frmPosaljiObavijest : Form
    {
        private readonly APIService _obavijest = new APIService("ponuda/dodajobavijest");
        private readonly int _ponudaId;

        public frmPosaljiObavijest(int ponudaId, string nazivPonude)
        {
            InitializeComponent();
            txtPonudaNaziv.Text = nazivPonude;
            _ponudaId = ponudaId;
        }

        private async void btnSaveForm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPonudaText.Text))
            {
                MessageBox.Show("Tekst obavijesti je prazan", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var obavijest = new ObavijestAdd
            {
                PonudaId = _ponudaId,
                Tekst = txtPonudaText.Text,
                Type = "notifikacija"
            };

            await _obavijest.Insert<object>(obavijest);
            MessageBox.Show("Uspješno ste poslali obavijest", "Obavijesti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
