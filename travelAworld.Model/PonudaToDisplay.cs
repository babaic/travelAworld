using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace travelAworld.Model
{
    public class PonudaToDisplay
    {
        public int PonudaId { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime DatumPovratka { get; set; }
        public float Cijena { get; set; }
        public string CijenaUkljuceno { get; set; }
        public string CijenaIskljuceno { get; set; }
        public string Napomena { get; set; }
        public string Hotel { get; set; }
        public string Lokacija { get; set; }
        public int DrzavaId { get; set; }
        public List<UsertoDisplay> Vodic { get; set; }
        public List<string> Slike { get; set; }
        public string Koordinate1 { get; set; }
        public string Koordinate2 { get; set; }
        public string _Drzava { get; set; }
        public string _Mjesto { get; set; }
        public bool IsActive { get; set; }


        public string setDatumOdDo()
        {
            return DatumPolaska.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) + " - " + DatumPovratka.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
