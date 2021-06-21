using travelAworld.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            var _role = App.Current.Properties["Role"].ToString();

            menuItems = new List<HomeMenuItem>();
            //{
            //    new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
            //    new HomeMenuItem {Id = MenuItemType.About, Title="About" },
            //    new HomeMenuItem {Id = MenuItemType.Obavijesti, Title="Obavijesti" },
            //    new HomeMenuItem {Id = MenuItemType.Poruke, Title="Poruke" },
            //    new HomeMenuItem {Id = MenuItemType.MojaPutovanjaUser, Title="Moja putovanja" }

            //};

            if (_role == "Member" || _role == "Administrator")
            {
                menuItems.Add(new HomeMenuItem { Id = MenuItemType.Browse, Title = "Ponude" });
                menuItems.Add(new HomeMenuItem { Id = MenuItemType.Preporuke, Title = "Preporuke" });
                menuItems.Add(new HomeMenuItem { Id = MenuItemType.MojaPutovanjaUser, Title = "Moje rezervacije" });
            }


            if(_role == "Administrator")
            {
                menuItems.Add(new HomeMenuItem { Id = MenuItemType.DodajStan, Title = "Dodaj stan" });
                menuItems.Add(new HomeMenuItem { Id = MenuItemType.RezervacijeZahtjevi, Title = "Zahtjevi za rezervacije" });
            }
            menuItems.Add(new HomeMenuItem { Id = MenuItemType.Postavke, Title = "Postavke" });
            menuItems.Add(new HomeMenuItem { Id = MenuItemType.Logout, Title = "Odjava" });

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}