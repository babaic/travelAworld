using eRent.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using travelAworld.Model;
using Xamarin.Forms;

namespace travelAworld.MobileApp.ViewModels
{
    public class PreporukeViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("nekretnina/preporuke");
        public ObservableCollection<NekretninaToDisplayVM> Ponude { get; set; } = new ObservableCollection<NekretninaToDisplayVM>();
        public PreporukeViewModel()
        {
            
        }

        public ICommand LoadPonudeCommand { get; set; }

        public void UcitajPonude()
        {
            Ponude.Clear();
            List<NekretninaToDisplayVM> ponude = _service.Get<List<NekretninaToDisplayVM>>(null);

            foreach (var ponuda in ponude)
            {
                Ponude.Add(ponuda);
            }

        }

    }
}
