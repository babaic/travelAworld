using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
public class Week
{
    public int DayNumber { get; set; }
    public string Dan { get; set; }
    public int BrojObaveza { get; set; }
}
public class MonkeysToDisplay
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
}

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        List<Week> week = new List<Week>();
        List<MonkeysToDisplay> Monkeys = new List<MonkeysToDisplay>();

        public TestPage()
        {
            InitializeComponent();
            loadList();
        }



        private void loadList()
        {
            week.Add(new Week { BrojObaveza = 2, Dan = "Ponedjeljak", DayNumber = 1 });
            week.Add(new Week { BrojObaveza = 6, Dan = "Utorak", DayNumber = 2 });
            week.Add(new Week { BrojObaveza = 4, Dan = "Srijeda", DayNumber = 3 });
            week.Add(new Week { BrojObaveza = 10, Dan = "Četvrtak", DayNumber = 4 });
            week.Add(new Week { BrojObaveza = 2, Dan = "Petak", DayNumber = 5 });
            week.Add(new Week { BrojObaveza = 1, Dan = "Subota", DayNumber = 6 });
            week.Add(new Week { BrojObaveza = 0, Dan = "Nedjelja", DayNumber = 7 });


            Monkeys.Add(new MonkeysToDisplay { Details = "gege", Name = "dewdw", Location = "dewfejgk", ImageUrl = "https://randomwordgenerator.com/img/picture-generator/54e7d1434d57ad14f1dc8460962e33791c3ad6e04e50744172297cd6904fc1_640.jpg" });
            Monkeys.Add(new MonkeysToDisplay { Details = "fefe", Name = "dewdw", Location = "dewfejgk", ImageUrl = "https://randomwordgenerator.com/img/picture-generator/close-up-photography-of-group-of-people-974320.jpg" });
            Monkeys.Add(new MonkeysToDisplay { Details = "grgrtg", Name = "dewdw", Location = "dewfejgk", ImageUrl = "https://randomwordgenerator.com/img/picture-generator/55e2dc4a4b52a414f1dc8460962e33791c3ad6e04e5074417d2d73dc9444c7_640.jpg" });
            Monkeys.Add(new MonkeysToDisplay { Details = "frefef", Name = "dewdw", Location = "dewfejgk", ImageUrl = "https://randomwordgenerator.com/img/picture-generator/crazy-horse-memorial-4577682_640.jpg" });
            Monkeys.Add(new MonkeysToDisplay { Details = "dwdewd", Name = "dewdw", Location = "dewfejgk", ImageUrl = "https://randomwordgenerator.com/img/picture-generator/55e0dd4b4e57a414f1dc8460962e33791c3ad6e04e50744172297bd69545c7_640.jpg" });
            nekaLista.ItemsSource = Monkeys;
        }


    }
}