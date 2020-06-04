using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.MobileApp.Models
{
    public class PonudaDetails
    {
        public int PonudaId { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime DatumPovratka { get; set; }
        public string Cijena { get; set; }
        public string CijenaUkljuceno { get; set; }
        public string CijenaIskljuceno { get; set; }
        public string Napomena { get; set; }
        public string Hotel { get; set; }
        public string Lokacija { get; set; }
        public int DrzavaId { get; set; }
        public List<string> Slike { get; set; }
        public double Koordinate1 { get; set; }
        public double Koordinate2 { get; set; }
        public string DatumOdDo { get; set; }

    }
}
