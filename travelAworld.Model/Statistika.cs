using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class Statistika
    {
        public List<TopThree> Top3 { get; set; }
        public int BrKorisnika { get; set; }
        public int BrRezervacija { get; set; }
        public int BrDestinacija { get; set; }
        public int BrPregleda { get; set; }
    }

    public class TopThree
    {
        public string NazivPutovanja { get; set; }
        public int UkupnoPrijavljeno { get; set; }
    }
}
