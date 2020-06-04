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
    public partial class ListaKorisnikaPage : ContentPage
    {
        private readonly APIService _service = new APIService("ponuda/getponudeusers");
        public ListaKorisnikaPage(int putovanjeid)
        {
            InitializeComponent();

            PonudaUserToSearch queryParams = new PonudaUserToSearch
            {
                PonudaId = putovanjeid,
                PageSize = 500
            };


            var result = _service.Get<PageResult<PonudaUserDisplay>>(queryParams);

            List<PonudaUserDisplay> korisnici = new List<PonudaUserDisplay>();

            korisnici = result.Items;

            listaKorisnika.ItemsSource = korisnici;


        }
    }
}