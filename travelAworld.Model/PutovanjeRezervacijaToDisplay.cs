using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class PutovanjeRezervacijaToDisplay
    {
        public int PonudaId { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime DatumPovratka { get; set; }
        public float Cijena { get; set; }
        public string Hotel { get; set; }
        public string Lokacija { get; set; }
        public int rezervacijaId { get; set; }
    }
}
