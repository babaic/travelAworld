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
    public partial class PaymentMsgPage : ContentPage
    {

        public string TextMessage { get; set; }
        public PaymentMsgPage()
        {
            InitializeComponent();

        }
        public PaymentMsgPage(bool success)
        {
            InitializeComponent();
            if (success)
            {
                responseTxt.Text = "Uspješno plaćeno.";
                slika.Source = "https://i.imgur.com/Qu5H4Ha.png";
            }
            else
            {
                responseTxt.Text = "Greška. Neuspješno plaćanje.";
                slika.Source = "https://i.imgur.com/SoQ9H5E.png";
            }
            
        }
    }
}