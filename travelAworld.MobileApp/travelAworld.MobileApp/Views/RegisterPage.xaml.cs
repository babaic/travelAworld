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
    public partial class RegisterPage : ContentPage
    {

        private readonly APIService _service = new APIService("user/register");
        private readonly APIService _login = new APIService("user/login");
        bool displayError = false;
        public RegisterPage()
        {
            InitializeComponent();
        }

        async void salji(object sender, EventArgs args)
        {
            var userToRegister = new UserToRegister
            {
                Ime = Ime.Text,
                Prezime = Prezime.Text,
                Email = Email.Text,
                Username = Username.Text,
                Password = Password.Text,
                Adresa = Adresa.Text,
                Dob = Dob.Date,
                Telefon = Telefon.Text,
                Role = "Member"
            };

            if(Ime.Text == null || Prezime.Text == null || Email.Text == null || Username.Text == null || Password.Text == null || Adresa.Text == null || Telefon.Text == null)
            {
                displayError = true;
                await DisplayAlert("Greška", "Popunite sva polja", "OK");
            }
            else
            {
                displayError = false;
            }

            if (!displayError)
            {
                var result = await _service.Insert<UsertoDisplay>(userToRegister);

                if (result != null)
                {
                    UserToLogin userToLogin = new UserToLogin
                    {
                        Username = Username.Text,
                        Password = Password.Text
                    };

                    var login = await _login.Insert<MyResponse>(userToLogin);
                    if (login.Token != "error")
                    {
                        App.Current.Properties.Remove("Token");
                        App.Current.Properties.Remove("UserId");
                        App.Current.Properties.Remove("Role");
                        App.Current.Properties.Add("Token", login.Token);
                        App.Current.Properties.Add("UserId", login.User.Id);
                        App.Current.Properties.Add("Role", login.User.Role);
                        await App.Current.SavePropertiesAsync();

                        //await Application.Current.MainPage.DisplayAlert("Token", App.Current.Properties["Token"].ToString(), "OK");

                        Application.Current.MainPage = new MainPage();
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "sss", "OK");
                    }
                }
            }
        }
    }
}