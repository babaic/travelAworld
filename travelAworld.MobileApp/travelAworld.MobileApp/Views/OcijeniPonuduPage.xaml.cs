using eRent.Model;
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
    public partial class OcijeniPonuduPage : ContentPage
    {
        private readonly APIService _ocijeni = new APIService("nekretnina/ocijeni");
        private readonly APIService _otkazi = new APIService("nekretnina/otkazi");


        private NekretninaToDisplayVM _ponuda;

        public OcijeniPonuduPage(NekretninaToDisplayVM ponudaToDisplay)
        {
            _ponuda = ponudaToDisplay;
            InitializeComponent();
        }

        public async void ocijeniRezervaciju(object sender, EventArgs args)
        {
            var rating = ocjena.Text;

            OcjeniPonuduVM ocjenaToAdd = new OcjeniPonuduVM
            {
                NekretninaId = _ponuda.NekretninaId,
                Ocjena = Int32.Parse(rating)
            };

            if(_ponuda.Ocjena > 0)
            {
                await DisplayAlert("PORUKA", "Već ste ocijenili rezervaciju.", "OK");
            }
            else if(_ponuda.Status == "OTKAZANO")
            {
                await DisplayAlert("PORUKA", "Rezervaciju nije moguće ocijeniti jer je otkazana", "OK");
            }
            else
            {
                await _ocijeni.InsertA<dynamic>(ocjenaToAdd);
                await DisplayAlert("PORUKA", "Ocijenili ste rezervaciju", "OK");
            }

            //await Navigation.PushAsync(new MojaPutovanjaPage());
        }

        private async void btnOtkazi_Clicked(object sender, EventArgs e)
        {
            if(_ponuda.Status == null || _ponuda.Status == "PRIHVACENO")
            {
                await DisplayAlert("PORUKA", "Rezervaciju nije moguće otkazati.", "OK");
                return;
            }
            else
            {
                _otkazi.Insert<dynamic>(_ponuda.RezervacijaId);
                await DisplayAlert("PORUKA", "Rezervacija otkazana.", "OK");
            }
        }
    }
}