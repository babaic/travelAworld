using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travelAworld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class Test
    {
        public string Tekst { get; set; }
        public string Objavio { get; set; }
    }
    public partial class ObavijestiPage : ContentPage
    {
        private readonly APIService _service = new APIService("ponuda/getobavijesti");

        List<ObavijestToDisplay> notifikacije = new List<ObavijestToDisplay>();

        public ObavijestiPage()
        {
            InitializeComponent();

            ObavijestToSearch queryParams = new ObavijestToSearch
            {
                Type = "notifikacija"
            };

            var result = _service.Get<List<ObavijestToDisplay>>(queryParams);

            obavijesti.ItemsSource = result;

        }
    }
}