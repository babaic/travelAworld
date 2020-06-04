using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class ObavijestToDisplay
    {
        public string Datum { get; set; }
        public string Objavio { get; set; }
        public int PonudaId { get; set; }
        public string Tekst { get; set; }
        public string PonudaNaslov { get; set; }

        //za poruke
        public string BrojClanova { get; set; }
        public string BrojPoruka { get; set; }
    }
}
