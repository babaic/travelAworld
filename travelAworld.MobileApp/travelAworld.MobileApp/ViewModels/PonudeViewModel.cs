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
    public class PonudeViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("nekretnina/GetNekretnina");
        public ObservableCollection<NekretninaToDisplayVM> Ponude { get; set; } = new ObservableCollection<NekretninaToDisplayVM>();
        NekretninaToDisplayVM ponuda1 = new NekretninaToDisplayVM();
        public PonudeViewModel()
        {
            
        }

        public ICommand LoadPonudeCommand { get; set; }

        public void UcitajPonude()
        {
            Ponude.Clear();
            PonudaToSearch ps = new PonudaToSearch { PrikaziObrisane = false };
            List<NekretninaToDisplayVM> ponude = _service.Get<List<NekretninaToDisplayVM>>(null);

            foreach (var ponuda in ponude)
            {
                Ponude.Add(ponuda);
            }

        }

    }
}
