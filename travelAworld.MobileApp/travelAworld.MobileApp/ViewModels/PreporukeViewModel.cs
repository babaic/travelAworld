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
        private readonly APIService _service = new APIService("ponuda/preporuke");
        public ObservableCollection<PonudaToDisplay> Ponude { get; set; } = new ObservableCollection<PonudaToDisplay>();
        PonudaToDisplay ponuda1 = new PonudaToDisplay();
        public PreporukeViewModel()
        {
            
        }

        public ICommand LoadPonudeCommand { get; set; }

        public void UcitajPonude()
        {
            Ponude.Clear();
            List<PonudaToDisplay> ponude = _service.Get<List<PonudaToDisplay>>(null);

            foreach (var ponuda in ponude)
            {
                Ponude.Add(ponuda);
            }

        }

    }
}
