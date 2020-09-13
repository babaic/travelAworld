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
    public partial class SettingsPage : ContentPage
    {
        private readonly APIService _editUser = new APIService("user/edituser");
        private readonly APIService _getUser = new APIService("user");
        private int userId = Int32.Parse(App.Current.Properties["UserId"].ToString());
        private UsertoDisplay userData;
        public SettingsPage()
        {
            InitializeComponent();

            loadData();
        }

        private async void loadData()
        {
            userData = await _getUser.GetById<UsertoDisplay>(userId);

            Ime.Text = userData.Ime;
            Prezime.Text = userData.Prezime;
            Email.Text = userData.Email;
            Adresa.Text = userData.Adresa;
            Dob.Date = userData.DatumRodjenja;
        }

        private async void SpasiPodatke(object sender, EventArgs e)
        {
            UserToEdit userToEdit = new UserToEdit
            {
                Adresa = Adresa.Text,
                Dob = Dob.Date,
                Email = Email.Text,
                Ime = Ime.Text,
                Prezime = Prezime.Text,
                Role = userData.Role
            };

            await _editUser.Update<dynamic>(userId, userToEdit);
        }
    }
}