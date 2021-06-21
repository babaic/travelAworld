using eRent.Model;
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
        public NekretninaToDisplayVM nekretnina;

        public class Lokacija
        {
            public string Position { get; set; }
        }

        public PonudaDetailPage(NekretninaToDisplayVM ponudaToDisplay)
        {

            InitializeComponent();

            nekretnina = new NekretninaToDisplayVM
            {
                Sprat = ponudaToDisplay.Sprat,
                Adresa = ponudaToDisplay.Adresa,
                BrojEtaza = ponudaToDisplay.BrojEtaza,
                Cijena = ponudaToDisplay.Cijena,
                GodinaIzgradnje = ponudaToDisplay.GodinaIzgradnje,
                Grad = ponudaToDisplay.Grad,
                Kvadratura = ponudaToDisplay.Kvadratura,
                Grijanje = ponudaToDisplay.Grijanje,
                PosjedujeKlimu = ponudaToDisplay.PosjedujeKlimu,
                PosjedujeLift = ponudaToDisplay.PosjedujeLift,
                UkljuceneRezije = ponudaToDisplay.UkljuceneRezije,
                Naziv = ponudaToDisplay.Naziv,
                Opis = ponudaToDisplay.Opis,
                NekretninaId = ponudaToDisplay.NekretninaId,
                KategorijaNekretnina = ponudaToDisplay.KategorijaNekretnina,
                Slike = ponudaToDisplay.Slike
            };
            
            BindingContext = nekretnina;
            Title = nekretnina.Naziv;

        }
        public PonudaDetailPage()
        {
            InitializeComponent();
        }

        public async void rezervisiPonudu(object sender, EventArgs args)
        {

            UserSelectPonuda userSelectPonuda = new UserSelectPonuda
            {
                UserId = Int32.Parse(App.Current.Properties["UserId"].ToString()),
                Cijena = (double)nekretnina.Cijena
            };


            await Navigation.PushAsync(new KupiPonudu(nekretnina, userSelectPonuda));
        }


    }
}