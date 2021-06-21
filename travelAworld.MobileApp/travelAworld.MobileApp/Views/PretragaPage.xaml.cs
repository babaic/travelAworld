using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PretragaPage : ContentPage
    {
        public PretragaPage()
        {
            InitializeComponent();
        }

        private void btnPretraga_Clicked(object sender, EventArgs e)
        {
            var kategorija = pickerKategorija.SelectedItem;
        }

        private void btnPonisti_Clicked(object sender, EventArgs e)
        {

        }
    }
}