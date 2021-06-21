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
    public partial class DodajStanPage : ContentPage
    {
        private readonly APIService _service = new APIService("nekretnina/nova");
        bool displayError = false;
        public DodajStanPage()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Clicked_1(object sender, EventArgs e)
        {
            List<string> slika = new List<string>();
            slika.Add(Slika.Text);

            var gradSelected = pickerGrad.SelectedItem;
            var gradId = 0;
            switch (gradSelected)
            {
                case "Sarajevo": gradId = 1; break;
                case "Zenica": gradId = 2; break;
                case "Mostar": gradId = 3; break;
            }

            var kategorijaSelected = pickerKategorija.SelectedItem;
            var kategorijaId = 0;
            switch (kategorijaSelected)
            {
                case "Stan": kategorijaId = 1; break;
                case "Kuca": kategorijaId = 2; break;
                case "Vikendica": kategorijaId = 3; break;
            }

            if (Naslov.Text == null || Adresa.Text == null || Cijena.Text == null || Velicina.Text == null || Slika.Text == null || pickerKategorija.SelectedItem == null || pickerGrad.SelectedItem == null)
            {
                displayError = true;
                await DisplayAlert("Greška", "Popunite sva polja", "OK");
                return;
            }
            else
            {
                displayError = false;
            }
            NekretninaToAddVM nekretnina = new NekretninaToAddVM
            {
                Naziv = Naslov.Text,
                Adresa = Adresa.Text,
                Cijena = Int32.Parse(Cijena.Text),
                Kvadratura = Int32.Parse(Velicina.Text),
                PosjedujeLift = Lift.IsChecked,
                UkljuceneRezije = Rezije.IsChecked,
                PosjedujeKlimu = Klima.IsChecked,
                Slike = slika,
                GradId = gradId,
                KategorijaNekretnineId = kategorijaId,
                Sprat = 1,
                BrojEtaza = 1,
                GodinaIzgradnje = 2020,
            };
            try
            {
                await _service.Insert<dynamic>(nekretnina);
                await DisplayAlert("Poruka", "Dodali ste nekretninu.", "OK");
            }
            catch(Exception exc)
            {
                await DisplayAlert("Greška", "Došlo je do greške.", "OK");
            }

        }
    }
}