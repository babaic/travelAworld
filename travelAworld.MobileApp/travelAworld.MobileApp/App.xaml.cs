using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using travelAworld.MobileApp.Services;
using travelAworld.MobileApp.Views;

namespace travelAworld.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU2MDQ5QDMxMzgyZTMxMmUzMEY5aFJqUURsQkhGRlpUNm5pc2JkZUFqYlFFcEg3Vi9CanY1bGRmd1ZMY1U9;MjU2MDUwQDMxMzgyZTMxMmUzMGwvNFNHU1hZdzBGVHRnNFgvOTEySnZlSC9WMVFPVnRXU01uSXpoTFIzMmc9");
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            if (App.Current.Properties.ContainsKey("Token"))
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new LoginPage();
            }

            MainPage = new LoginPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
