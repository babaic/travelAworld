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
    public partial class MojaPutovanjaPage : ContentPage
    {
        private readonly APIService _service = new APIService("ponuda/getaktivnaputovanja");
        private readonly string _role;

        public MojaPutovanjaPage()
        {

            InitializeComponent();

            AktivnaPutovanjaPretraga q = new AktivnaPutovanjaPretraga();

            _role = App.Current.Properties["Role"].ToString();

            if (_role == "Member" || _role == "Administrator")
            {
                q.userId = Int32.Parse(App.Current.Properties["UserId"].ToString());
            }
            //if (_role == "Vodić")
            //{
            //    q.vodicId = Int32.Parse(App.Current.Properties["UserId"].ToString());
            //}

            var putovanja = _service.Get<List<PonudaToDisplay>>(q);

            listaPutovanja.ItemsSource = putovanja;
        }

    }
}