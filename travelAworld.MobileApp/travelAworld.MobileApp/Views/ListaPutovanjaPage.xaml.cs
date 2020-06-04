using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travelAworld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPutovanjaPage : ContentPage
    {
        private readonly APIService _service = new APIService("ponuda/getaktivnaputovanja");
        private readonly APIService _obavijest = new APIService("ponuda/dodajobavijest");
        private readonly string _role;

        public ListaPutovanjaPage()
        {

            InitializeComponent();

            AktivnaPutovanjaPretraga q = new AktivnaPutovanjaPretraga();

            _role = App.Current.Properties["Role"].ToString();

            //if (_role == "Member" || _role == "Administrator")
            //{
            //    q.userId = Int32.Parse(App.Current.Properties["UserId"].ToString());
            //}
            if (_role == "Vodić")
            {
                q.vodicId = Int32.Parse(App.Current.Properties["UserId"].ToString());
            }

            var putovanja = _service.Get<List<PonudaToDisplay>>(q);

            listaPutovanja.ItemsSource = putovanja;
        }

        private async void posaljiObavijest(object Sender, EventArgs e)
        {
            Button button = (Button)Sender;
            string ID = button.CommandParameter.ToString();

            string result = await DisplayPromptAsync("Pošalji obavijest", "Tekst");
            var obavijest = new ObavijestAdd
            {
                PonudaId = Int32.Parse(ID),
                Tekst = result,
                Type = "notifikacija"
            };

            await _obavijest.InsertA<object>(obavijest);
            
            await DisplayAlert("Poruka", "Obavijest poslana!", "OK");
        }

        private async void prikazClanova(object Sender, EventArgs e)
        {
            Button button = (Button)Sender;
            string ID = button.CommandParameter.ToString();


            await Navigation.PushAsync(new ListaKorisnikaPage(Int32.Parse(ID)));
        }
    }
}