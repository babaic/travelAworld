using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using travelAworld.Model;
using travelAworld.MobileApp.Models;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KupiPonudu : ContentPage
    {
        private readonly APIService _service = new APIService("uplata/pay");
        private readonly APIService _servicePonudaUser = new APIService("ponuda/ponudauser");
        private double _amount { get; set; }
        private PonudaDetails _ponuda;
        private UserSelectPonuda _userSelectPonuda;

        public KupiPonudu()
        {
            InitializeComponent();
        }
        public KupiPonudu(PonudaDetails ponuda, UserSelectPonuda userSelectPonuda)
        {
            InitializeComponent();
            cijena.Text = userSelectPonuda.Cijena.ToString()+" KM";
            _amount = userSelectPonuda.Cijena;
            _ponuda = ponuda;
            _userSelectPonuda = userSelectPonuda;
        }
        async void kupiPonudu(object sender, EventArgs args)
        {
            //PaymentCardAdd card = new PaymentCardAdd
            //{
            //    BrojKartice = Int32.Parse(brojKartice.Text),
            //    Mjesec = Int32.Parse(mjesec.Text),
            //    Godina = Int32.Parse(godina.Text),
            //    CVV = Int32.Parse(cvv.Text),
            //    Amount = Convert.ToInt64(_amount),
            //    Desc = _ponuda.Naslov+"_"+_userSelectPonuda.UserId
            //};

            PaymentCardAdd card = new PaymentCardAdd
            {
                BrojKartice = "4242424242424242",
                Mjesec = Int32.Parse("5"),
                Godina = Int32.Parse("21"),
                CVV = Int32.Parse("123"),
                Amount = Convert.ToInt64(_amount),
                Desc = _ponuda.Naslov + "_" + _userSelectPonuda.UserId

            };

            var result = await _service.InsertA<Uplata>(card);

            if (result.Status == "succeeded")
            {
                //dodaj u bazu podatke 
                var ponudaUser = new PonudaUserAdd
                {
                    BrojOsoba = _userSelectPonuda.BrojOsoba,
                    TipSobe = _userSelectPonuda.TipSobe,
                    Cijena = _userSelectPonuda.Cijena,
                    UserId = _userSelectPonuda.UserId,
                    PonudaId = _ponuda.PonudaId,
                    TransakcijaId = result.ChargeId
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