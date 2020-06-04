using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class ObavijestAdd
    {
        public DateTime Datum { get; set; }
        public int ObjavioId { get; set; }
        public int PonudaId { get; set; }
        public string Tekst { get; set; }
        public string Type { get; set; }
    }
}
