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
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();

            App.Current.Properties.Remove("Token");
            App.Current.Properties.Remove("UserId");
            App.Current.Properties.Remove("Role");

            Application.Current.MainPage = new LoginPage();

        }
    }
}