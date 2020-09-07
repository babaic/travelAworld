using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class LokacijaToDisplay
    {
        public int LokacijaId { get; set; }
        public string Mjesto { get; set; }
        public string Drzava { get; set; }
        public int DrzavaId { get; set; }
        public string FullLokacija { get; set; }
        
        public string setFullLokacija 
        { 
            get { return FullLokacija; }
            set { FullLokacija = Mjesto +" ("+ Drzava +")"; }
        }
        
    }
}
