using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        Preporuke,
        About,
        Obavijesti,
        Poruke,
        MojaPutovanja,
        MojaPutovanjaUser,
        Postavke,
        DodajStan,
        Logout,
        RezervacijeZahtjevi
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
