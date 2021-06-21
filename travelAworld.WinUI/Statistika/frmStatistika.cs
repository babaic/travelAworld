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

namespace travelAworld.WinUI.Statistika
{
    public partial class frmStatistika : Form
    {
        private readonly APIService _getpopularne = new APIService("nekretnina/statistika");
        public frmStatistika()
        {
            InitializeComponent();


            var statistika = _getpopularne.Get<StatistikaVM>(null);

            foreach (var item in statistika.Top3)
            {
                chart1.Series.Add(item.NazivNekretnine);
                chart1.Series[item.NazivNekretnine].Points.AddXY(item.NazivNekretnine, item.UkupnoRentano);
            }

            txtBrIzdatihStanova.Text = statistika.TrenutnoIzdatihStanova.ToString();
            txtBrKorisnika.Text = statistika.BrojKorisnika.ToString();
            txtBrTotalStanovi.Text = statistika.UkupnoIzdatihStanova.ToString();
            txtBrUgovori.Text = statistika.UkupnoZakljucenihUgovora.ToString();

        }
    }
}
