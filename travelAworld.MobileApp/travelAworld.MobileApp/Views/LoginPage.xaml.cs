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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!", "The button labeled '" + button.Text + "' has been clicked", "OK");

            //App.Current.Properties.Add("test", "HUIHT8nhiuehnrf7878");
        }

        //async void SignIn(object sender, EventArgs args)
        //{
        //    IsBusy = true;

        //    UserToLogin userToLogin = new UserToLogin
        //    {
        //        Username = usernameEntry.Text,
        //        Password = passwordEntry.Text
        //    };

        //    var result = await _apiService.Insert<MyResponse>(userToLogin);

        //    if (result.Token != "error")
        //    {
        //        await DisplayAlert("Token", result.Token, "OK");

        //    }
        //    else
        //    {
        //        await DisplayAlert("Error", "Failed to login", "OK");
        //    }

        //    //await DisplayAlert("Login data", usernameEntry.Text + ", " + passwordEntry.Text, "OK");
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Registracija(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new RegisterPage());
            Application.Current.MainPage = new RegisterPage();
        }
    }
}