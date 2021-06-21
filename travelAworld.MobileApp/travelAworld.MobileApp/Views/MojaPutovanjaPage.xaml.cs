using eRent.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travelAworld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojaPutovanjaPage : ContentPage
    {
        private readonly APIService _service = new APIService("nekretnina/GetRezervisaneNekretnine");
        private readonly APIService _ocijena = new APIService("nekretnina/ocijeni");
        string _role;
        ObservableCollection<NekretninaToDisplayVM> nekretnineList = new ObservableCollection<NekretninaToDisplayVM>();

        AktivnaPutovanjaPretraga q = new AktivnaPutovanjaPretraga();

        public MojaPutovanjaPage()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            _role = App.Current.Properties["Role"].ToString();

            if (_role == "Member" || _role == "Administrator")
            {
                q.userId = Int32.Parse(App.Current.Properties["UserId"].ToString());
            }

            nekretnineList.Clear();
            var nekretnine = _service.Get<List<NekretninaToDisplayVM>>(q);

            foreach (var nekretnina in nekretnine)
            {
                nekretnineList.Add(nekretnina);
            }

            listaNekretnina.ItemsSource = nekretnineList;
        }

        protected override async void OnAppearing()
        {
            //Write the code of your page here
            LoadData();
            base.OnAppearing();
        }

        public async void ocijeniRezervaciju(object sender, EventArgs args)
        {
            string result = await DisplayPromptAsync("Ocijeni smještaj", "Ocjena od 1 do 10", keyboard: Keyboard.Numeric);


            //await Navigation.PushAsync(new KupiPonudu(nekretnina, userSelectPonuda));
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var ponuda = args.SelectedItem as NekretninaToDisplayVM;
            if (ponuda == null)
                return;

            await Navigation.PushAsync(new OcijeniPonuduPage(ponuda));

            // Manually deselect item.
            // ItemsListView.SelectedItem = null;
        }

    }
}