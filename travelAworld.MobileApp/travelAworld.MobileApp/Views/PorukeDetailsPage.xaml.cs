using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travelAworld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace travelAworld.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PorukeDetailsPage : ContentPage
    {
        private readonly APIService _getPoruke = new APIService("ponuda/getobavijesti");
        private readonly APIService _posaljiPoruku = new APIService("ponuda/dodajobavijest");
        private readonly int _ponudaId;

        ObservableCollection<ObavijestToDisplay> poruke = new ObservableCollection<ObavijestToDisplay>();

        public PorukeDetailsPage()
        {

            InitializeComponent();

            //poruke.Add("Sed cursus urna id sapien lobortis, a fringilla ante fermentum");
            //poruke.Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eu tempor nunc, sed egestas felis.");
            //poruke.Add("hfuireh guie ghieughieu");
            //poruke.Add("g eighehg euheiut gheiug heg ieug h");
            //poruke.Add("gjeghieu hgeiu hgeuih gieuthg ieut ");
            //poruke.Add("he utgh tue hgeiu heit guieth iethie iehg");
            //poruke.Add("heugh iegh eih ietwiog ewig eiwgh");
            //poruke.Add("epiog hept eo pog gojh");
            //poruke.Add("gtioeg jewoit heowithgqel");
            //poruke.Add("neigoet ihotugh tioeu gkjhtkuf tktuj");
            //poruke.Add("jeorifjo");
            //poruke.Add("jgtiogj oitj");
            //poruke.Add("jgtueii uhkweri ghruight ui");
            //poruke.Add("ntoihiu ghitu rhirbhriubri bu");
            //poruke.Add("iurhgtuig hrthritu iub");
            //poruke.Add("iurghir hgriuhr  ph urih biu");
            //poruke.Add("trzbzhh hth tjhj");
            //poruke.Add("htzjhthtujj ");
            //poruke.Add("jtuzjjzh");
            //poruke.Add("nhujzhnujhnzu");
            //poruke.Add("hzunethregrbr r5hzzzzz");
            //poruke.Add("iurfhieruh gite ");
            //poruke.Add("he utgh tue hgeiu heit guieth iethie iehg");
            //poruke.Add("heugh iegh eih ietwiog ewig eiwgh");
            //poruke.Add("epiog hept eo pog gojh");
            //poruke.Add("gtioeg jewoit heowithgqel");
            //poruke.Add("jgtiogj oitj");
            //poruke.Add("jgtueii uhkweri ghruight ui");
            //poruke.Add("ntoihiu ghitu rhirbhriubri bu");
            //poruke.Add("he utgh tue hgeiu heit guieth iethie iehg");
            //poruke.Add("heugh iegh eih ietwiog ewig eiwgh");
            //poruke.Add("epiog hept eo pog gojh");
            //poruke.Add("last msg");

            //porukeList.ItemsSource = poruke;

            //GoToLastMsg();
        }

        public PorukeDetailsPage(int ponudaId)
        {
            InitializeComponent();
            _ponudaId = ponudaId;
            Title = "Poruke";

            loadData();

            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                loadData();
                return true;
            });

        }

        private void loadData()
        {
            poruke.Clear();

            ObavijestToSearch queryParams = new ObavijestToSearch
            {
                Type = "poruka",
                PonudaId = _ponudaId
            };

            var result = _getPoruke.Get<List<ObavijestToDisplay>>(queryParams);

            foreach (var item in result)
            {
                poruke.Add(item);
            }

            porukeList.ItemsSource = poruke;

            GoToLastMsg();
        }

        async void posaljiPoruku(object sender, EventArgs e)
        {
            var poruka = new ObavijestAdd
            {
                PonudaId = _ponudaId,
                Tekst = mojaPoruka.Text,
                Type = "poruka"
            };

            await _posaljiPoruku.InsertA<dynamic>(poruka);
            loadData();

            mojaPoruka.Text = null;

            GoToLastMsg();
        }

        private void GoToLastMsg()
        {
            var last = porukeList.ItemsSource.Cast<object>().LastOrDefault();
            porukeList.ScrollTo(last, ScrollToPosition.MakeVisible, true);
        }
    }
}