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
        private readonly APIService _service = new APIService("ponuda/getponude");
        public ObservableCollection<PonudaToDisplay> Ponude { get; set; } = new ObservableCollection<PonudaToDisplay>();
        PonudaToDisplay ponuda1 = new PonudaToDisplay();
        public PonudeViewModel()
        {
            
        }

        public ICommand LoadPonudeCommand { get; set; }

        public void UcitajPonude()
        {
            Ponude.Clear();
            PonudaToSearch ps = new PonudaToSearch { PrikaziObrisane = false };
            PageResult<PonudaToDisplay> ponude = _service.Get<PageResult<PonudaToDisplay>>(ps);

            foreach (var ponuda in ponude.Items)
            {
                Ponude.Add(ponuda);
            }

        }

    }
}
