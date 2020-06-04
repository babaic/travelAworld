using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class PonudaToAdd
    {
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime DatumPovratka { get; set; }
        public float Cijena { get; set; }
        public string CijenaUkljuceno { get; set; }
        public string CijenaIskljuceno { get; set; }
        public string Napomena { get; set; }
        public string Hotel { get; set; }
        public int LokacijaId { get; set; }
        public List<int> VodicId { get; set; }
        public List<string> Slike { get; set; }
        public string Koordinate1 { get; set; }
        public string Koordinate2 { get; set; }
    }
}
