using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using travelAworld.Model;
using Xamarin.Forms;

namespace travelAworld.MobileApp.ViewModels
{
    public class ListaPutovanjaViewModel
    {
        private readonly APIService _service = new APIService("ponuda/getaktivnaputovanja");
        private readonly string _role;

        public List<PonudaToDisplay> Ponude { get; set; }


        public ListaPutovanjaViewModel()
        {
            PosaljiObavijestCommand = new Command<string>(PosaljiObavijest);

            AktivnaPutovanjaPretraga q = new AktivnaPutovanjaPretraga();

            _role = App.Current.Properties["Role"].ToString();

            if (_role == "Member" || _role == "Administrator")
            {
                q.userId = Int32.Parse(App.Current.Properties["UserId"].ToString());
            }
            if (_role == "Vodić")
            {
                q.vodicId = Int32.Parse(App.Current.Properties["UserId"].ToString());
            }

            Ponude = _service.Get<List<PonudaToDisplay>>(q);
        }


        public ICommand PosaljiObavijestCommand { get; set; }
        
        private void PosaljiObavijest(string obj)
        {
            var s = obj;
            var result  = Application.Current.MainPage.DisplayPromptAsync("Pošalji obavijest", "Tekst");
        }
    }
}
