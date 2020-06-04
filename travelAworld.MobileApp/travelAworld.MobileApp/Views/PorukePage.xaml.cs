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
    public partial class PorukePage : ContentPage
    {
        private readonly APIService _service = new APIService("ponuda/getobavijesti");
        List<ObavijestToDisplay> poruke = new List<ObavijestToDisplay>();
        public PorukePage()
        {
            InitializeComponent();

            ObavijestToSearch queryParams = new ObavijestToSearch
            {
                Type = "poruka"
            };

            var result = _service.Get<List<ObavijestToDisplay>>(queryParams);
            porukeList.ItemsSource = result;

        }

        async void porukeList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var grupa = e.SelectedItem as ObavijestToDisplay;
            if (grupa == null)
                return;

            await Navigation.PushAsync(new PorukeDetailsPage(grupa.PonudaId));
            //await Navigation.PushAsync(new NavigationPage(new PorukeDetailsPage(grupa.PonudaId)));
        }
    }
}