using eRent.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijeZahtjevi : ContentPage
    {
        private readonly APIService _service = new APIService("nekretnina/zahtjeviRezervacije");
        string _role;
        ObservableCollection<RezervacijaZahtjevVM> rezervacijeZahtjevi = new ObservableCollection<RezervacijaZahtjevVM>();

        public RezervacijeZahtjevi()
        {
            InitializeComponent();
        }

        public void LoadData()
        {

            rezervacijeZahtjevi.Clear();
            var rezervacije = _service.Get<List<RezervacijaZahtjevVM>>(null);

            foreach (var rezervacija in rezervacije)
            {
                rezervacijeZahtjevi.Add(rezervacija);
            }

            listaRezervacija.ItemsSource = rezervacijeZahtjevi;
        }

        protected override async void OnAppearing()
        {
            //Write the code of your page here
            LoadData();
            base.OnAppearing();
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var ponuda = args.SelectedItem as RezervacijaZahtjevVM;
            if (ponuda == null)
                return;

            await Navigation.PushAsync(new NapraviUgovor(ponuda));

            // Manually deselect item.
            // ItemsListView.SelectedItem = null;
        }
    }
}