using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using travelAworld.MobileApp.Models;

namespace travelAworld.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Preporuke:
                        MenuPages.Add(id, new NavigationPage(new PreporukePage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Obavijesti:
                        MenuPages.Add(id, new NavigationPage(new ObavijestiPage()));
                        break;
                    case (int)MenuItemType.Poruke:
                        MenuPages.Add(id, new NavigationPage(new PorukePage()));
                        break;
                    case (int)MenuItemType.MojaPutovanja:
                        MenuPages.Add(id, new NavigationPage(new ListaPutovanjaPage()));
                        break;
                    case (int)MenuItemType.MojaPutovanjaUser:
                        MenuPages.Add(id, new NavigationPage(new MojaPutovanjaPage()));
                        break;
                    case (int)MenuItemType.Logout:
                        MenuPages.Add(id, new NavigationPage(new LogoutPage()));
                        break;
                    case (int)MenuItemType.Postavke:
                        MenuPages.Add(id, new NavigationPage(new SettingsPage()));
                        break;
                    case (int)MenuItemType.DodajStan:
                        MenuPages.Add(id, new NavigationPage(new DodajStanPage()));
                        break;
                    case (int)MenuItemType.RezervacijeZahtjevi:
                        MenuPages.Add(id, new NavigationPage(new RezervacijeZahtjevi()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}