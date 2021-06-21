using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using travelAworld.MobileApp.Views;
using travelAworld.Model;
using Xamarin.Forms;

namespace travelAworld.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("user/login");
        //private readonly APIService _service = new APIService("ponuda/getdrzave");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;

            UserToLogin userToLogin = new UserToLogin
            {
                Username = Username,
                Password = Password
            };



            var result = await _service.Insert<MyResponse>(userToLogin);
            if (result.Token != "error")
            {
                App.Current.Properties.Remove("Token");
                App.Current.Properties.Remove("UserId");
                App.Current.Properties.Remove("Role");
                App.Current.Properties.Add("Token", result.Token);
                App.Current.Properties.Add("UserId", result.User.Id);
                App.Current.Properties.Add("Role", result.User.Role);
                await App.Current.SavePropertiesAsync();

                //await Application.Current.MainPage.DisplayAlert("Token", App.Current.Properties["Token"].ToString(), "OK");

                Application.Current.MainPage = new MainPage();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime ili lozinka netačni", "OK");
            }

            IsBusy = false;

            //var result = _service.Get<List<LokacijaToDisplay>>(null);

        }


    }
}
