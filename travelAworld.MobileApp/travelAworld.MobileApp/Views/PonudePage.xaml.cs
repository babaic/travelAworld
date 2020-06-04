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
    public partial class PonudePage : ContentPage
    {
        private readonly APIService _service = new APIService("ponuda/getponude");
        private PonudeViewModel model = null;
        public PonudePage()
        {
            InitializeComponent();
            BindingContext = model = new PonudeViewModel();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.UcitajPonude();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var ponuda = args.SelectedItem as PonudaToDisplay;
            if (ponuda == null)
                return;

            //await Navigation.PushAsync(new NavigationPage(new PonudaDetailPage(ponuda)));
            await Navigation.PushAsync(new PonudaDetailPage(ponuda));

            // Manually deselect item.
            // ItemsListView.SelectedItem = null;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            var txt = searchBar.Text;
            listaPonuda.ItemsSource = pretragaPonuda(searchBar.Text);
        }

        List<PonudaToDisplay> pretragaPonuda(string query)
        {
            PonudaToSearch q = new PonudaToSearch
            {
                Naziv = query,
                PageSize = 100
            };
            var result = _service.Get<PageResult<PonudaToDisplay>>(q);

            return result.Items;
        }
    }
}