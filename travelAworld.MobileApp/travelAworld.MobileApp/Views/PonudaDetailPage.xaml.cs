using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travelAworld.MobileApp.Models;
using travelAworld.MobileApp.ViewModels;
using travelAworld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PonudaDetailPage : ContentPage
    {
        private readonly APIService _zabiljeziPosjetu= new APIService("ponuda/zabiljeziposjetu");
        public PonudaDetails ponuda;
        public string tipSobe { get; set; }
        public int brOsoba { get; set; }
        public double Cijena { get; set; }

        public class Lokacija
        {
            public string Position { get; set; }
        }

        public PonudaDetailPage(PonudaToDisplay ponudaToDisplay)
        {

            InitializeComponent();

            btnRezervisi.IsEnabled = false;
            Cijena = ponudaToDisplay.Cijena;

            ponuda = new PonudaDetails
            {
                PonudaId = ponudaToDisplay.PonudaId,
                Naslov = ponudaToDisplay.Naslov,
                Opis = ponudaToDisplay.Opis,
                Hotel = ponudaToDisplay.Hotel,
                DatumOdDo = ponudaToDisplay.setDatumOdDo(),
                Lokacija = ponudaToDisplay.Lokacija,
                Cijena = ponudaToDisplay.Cijena.ToString() + "KM",
                Slike = ponudaToDisplay.Slike,
                Koordinate1 = Convert.ToDouble(ponudaToDisplay.Koordinate1, CultureInfo.InvariantCulture),
                Koordinate2 = Convert.ToDouble(ponudaToDisplay.Koordinate2, CultureInfo.InvariantCulture),

            };
            
            BindingContext = ponuda;
            Title = ponuda.Naslov;

            List<Lokacija> lok = new List<Lokacija>();
            //lok.Add(new Lokacija { Position = "128.841262, -18.333133" });
            lok.Add(new Lokacija { Position = "36.9628066, -122.0194722" });

            MyMap.ItemsSource = lok;

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(ponuda.Koordinate1, ponuda.Koordinate2), Distance.FromKilometers(5)));
            Pin pin = new Pin
            {
                Label = "Santa Cruz",
                Address = "The city with a boardwalk",
                Type = PinType.Place,
                Position = new Position(ponuda.Koordinate1, ponuda.Koordinate2)
            };
            MyMap.Pins.Add(pin);

            _zabiljeziPosjetu.GetById<dynamic>(ponudaToDisplay.PonudaId);

        }
        public PonudaDetailPage()
        {
            InitializeComponent();
        }

        private void GetSoba(object sender, EventArgs e)
        {
            tipSobe = odaberiSoba.SelectedItem.ToString(); // This is the model selected in the picker
            validate();
            
        }

        private void GetBrOsoba(object sender, EventArgs e)
        {
            brOsoba = Int32.Parse(odaberiBrojOsoba.SelectedItem.ToString());
            validate();
           
        }

        private void validate()
        {
            if(tipSobe!=null && brOsoba > 0)
            {
                btnRezervisi.IsEnabled = true;
            }
        }

        public async void rezervisiPonudu(object sender, EventArgs args)
        {

            UserSelectPonuda userSelectPonuda = new UserSelectPonuda
            {
                UserId = Int32.Parse(App.Current.Properties["UserId"].ToString()),
                BrojOsoba = brOsoba,
                TipSobe = tipSobe,
                Cijena = calculatePrice()
            };


            await Navigation.PushAsync(new KupiPonudu(ponuda,userSelectPonuda));
        }

        double calcPriceTipSobe(string tipSobe)
        {
            double price = 0;
            switch (tipSobe)
            {
                case "Jednokrevetna": price = 0;break;
                case "Dvokrevetna": price = 200;break;
                case "Trokrevetna": price = 300; break;
                case "Četverokrevetna": price = 400;break;
                default:break;
            }
            return price;
        }

        private double calculatePrice()
        {
           return Cijena += brOsoba + calcPriceTipSobe(tipSobe);
        }



    }
}