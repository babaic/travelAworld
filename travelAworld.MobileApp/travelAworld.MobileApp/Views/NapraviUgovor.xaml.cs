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
    public partial class NapraviUgovor : ContentPage
    {
        private readonly APIService _service = new APIService("nekretnina/napraviUgovor");
        private readonly APIService _odbij = new APIService("nekretnina/odbijUgovor");
        private readonly RezervacijaZahtjevVM _rezervacija;
        bool btnEnabled = true;

        public NapraviUgovor(RezervacijaZahtjevVM rezervacija)
        {
            InitializeComponent();
            _rezervacija = rezervacija;
        }

        private async void prihvati_Pressed(object sender, EventArgs e)
        {
            string emailSadrzaj = await DisplayPromptAsync("Pošaljite email", "Informacije u preuzimanju ključa:");
            _rezervacija.EmailSadrzaj = emailSadrzaj;
            await _service.InsertA<dynamic>(_rezervacija);
            prihvati.IsEnabled = false;
            odbij.IsEnabled = false;
            await DisplayAlert("Poruka", "Ugovor zakljucen!", "OK");
        }

        private async void odbij_Pressed(object sender, EventArgs e)
        {
            prihvati.IsEnabled = false;
            odbij.IsEnabled = false;
            _rezervacija.Status = "ODBIJENO";
            await _service.InsertA<dynamic>(_rezervacija);
            await DisplayAlert("Poruka", "Odbili ste rezervaciju", "OK");
        }
    }
}