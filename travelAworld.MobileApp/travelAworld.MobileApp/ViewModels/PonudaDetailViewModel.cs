using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using travelAworld.Model;

namespace travelAworld.MobileApp.ViewModels
{
    public class PonudaDetailViewModel
    {
        public PonudaToDisplay ponuda { get; set; } = new PonudaToDisplay { Naslov = "frjeoije" };


        public PonudaDetailViewModel(PonudaToDisplay ponudaToDisplay = null)
        {
            ponuda = new PonudaToDisplay { Naslov = "frjeoije" };
        }

        public PonudaDetailViewModel()
        {
            ponuda = new PonudaToDisplay { Naslov = "lplplpl" };
        }

    }
}
