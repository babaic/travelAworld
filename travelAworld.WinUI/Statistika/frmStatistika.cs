using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelAworld.WinUI.Statistika
{
    public partial class frmStatistika : Form
    {
        private readonly APIService _getpopularne = new APIService("ponuda/popularnaputovanja");
        public frmStatistika()
        {
            InitializeComponent();


            var statistika = _getpopularne.Get<Model.Statistika>(null);

            foreach (var item in statistika.Top3)
            {
                chart1.Series.Add(item.NazivPutovanja);
                chart1.Series[item.NazivPutovanja].Points.AddXY(item.NazivPutovanja, item.UkupnoPrijavljeno);
            }

            txtBrDestinacija.Text = statistika.BrRezervacija.ToString();
            txtBrKorisnika.Text = statistika.BrKorisnika.ToString();
            txtBrPregleda.Text = statistika.BrPregleda.ToString();
            txtBrRezervacija.Text = statistika.BrRezervacija.ToString();

        }
    }
}
