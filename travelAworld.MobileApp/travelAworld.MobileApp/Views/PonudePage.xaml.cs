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
    public partial class PonudePage : ContentPage
    {
        private readonly APIService _service = new APIService("nekretnina/GetNekretnina");
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
            var ponuda = args.SelectedItem as NekretninaToDisplayVM;
            if (ponuda == null)
                return;

            await Navigation.PushAsync(new PonudaDetailPage(ponuda));

            // Manually deselect item.
            // ItemsListView.SelectedItem = null;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //SearchBar searchBar = (SearchBar)sender;
            //var txt = searchBar.Text;
            //listaPonuda.ItemsSource = pretragaPonuda(searchBar.Text);
        }

        List<NekretninaToDisplayVM> pretragaPonuda(NekretninaToSearchVM q)
        {
            var result = _service.Get<List<NekretninaToDisplayVM>>(q);

            return result;
        }

        private void btnPretraga_Clicked(object sender, EventArgs e)
        {
            var gradSelected = pickerGrad.SelectedItem;
            var gradId = 0;
            switch(gradSelected)
            {
                case "Sarajevo" : gradId = 1; break;
                case "Zenica" : gradId = 2; break;
                case "Mostar": gradId = 3; break;
            }

            var kategorijaSelected = pickerKategorija.SelectedItem;
            var kategorijaId = 0;
            switch (kategorijaSelected)
            {
                case "Stan": kategorijaId = 1; break;
                case "Kuca": kategorijaId = 2; break;
                case "Vikendica": kategorijaId = 3; break;
            }


            var q = new NekretninaToSearchVM
            {
                Cijena = CijenaDo.Text == null ? 99999 : Int32.Parse(CijenaDo.Text),
                GradId = gradId,
                KategorijaNekretnineId = kategorijaId
            };
            listaPonuda.ItemsSource = pretragaPonuda(q);
        }

        private void btnPonisti_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PonudePage());
        }
    }
}