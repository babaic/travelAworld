using eRent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travelAworld.MobileApp.ViewModels;
using travelAworld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreporukePage : ContentPage
    {
        private readonly APIService _service = new APIService("nekretnina/preporuke");
        private PreporukeViewModel model = null;
        public PreporukePage()
        {
            InitializeComponent();
            BindingContext = model = new PreporukeViewModel();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.UcitajPonude();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var ponuda = args.SelectedItem as NekretninaToDisplayVM;
            if (ponuda == null)
                return;

            await Navigation.PushAsync(new PonudaDetailPage(ponuda));

        }

    }
}