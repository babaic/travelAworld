using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using travelAworld.Model;
using travelAworld.MobileApp.Models;
using eRent.Model;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KupiPonudu : ContentPage
    {
        private readonly APIService _service = new APIService("uplata/pay");
        private readonly APIService _servicePonudaUser = new APIService("nekretnina/ponudauser");
        private double _amount { get; set; }
        private NekretninaToDisplayVM _ponuda;
        private UserSelectPonuda _userSelectPonuda;
        DateTime MinDate = DateTime.Now;

        public KupiPonudu()
        {
            InitializeComponent();
        }
        public KupiPonudu(NekretninaToDisplayVM ponuda, UserSelectPonuda userSelectPonuda)
        {
            InitializeComponent();
            cijena.Text = userSelectPonuda.Cijena.ToString()+" KM";
            _amount = userSelectPonuda.Cijena;
            _ponuda = ponuda;
            _userSelectPonuda = userSelectPonuda;
        }
        async void kupiPonudu(object sender, EventArgs args)
        {
            var datumAdd = datum.Date;
            var prijavaAdd = prijava.Time.ToString();
            var odjavaAdd = odjava.Time.ToString();

            PaymentCardAdd card = new PaymentCardAdd
            {
                BrojKartice = "4242424242424242",
                Mjesec = Int32.Parse("5"),
                Godina = Int32.Parse("21"),
                CVV = Int32.Parse("123"),
                Amount = Convert.ToInt64(_amount),
                Desc = _ponuda.Naziv + "_" + _userSelectPonuda.UserId

            };

            if(brojKartice.Text == null || mjesec == null || godina == null)
            {
                await DisplayAlert("Napomena", "Podaci su obavezni, mozete unijeti bilo koje podatke jer se salju testni podaci na Stripe API", "OK");
            }

            var result = await _service.InsertA<Uplata>(card);

            if (result.Status == "succeeded")
            {
                //dodaj u bazu podatke 
                var ponudaUser = new PonudaUserAdd
                {
                    Cijena = _userSelectPonuda.Cijena,
                    UserId = _userSelectPonuda.UserId,
                    PonudaId = _ponuda.NekretninaId,
                    TransakcijaId = result.ChargeId,
                    DatumPrijave = datum.Date,
                    VrijemePrijave = prijava.Time.ToString(),
                    VrijemeOdjave = odjava.Time.ToString()
            };
                _servicePonudaUser.InsertA<dynamic>(ponudaUser);

                await Navigation.PushAsync(new PaymentMsgPage(true));
            }
            else
            {
                await Navigation.PushAsync(new PaymentMsgPage(false));
            }
        }

    }
}