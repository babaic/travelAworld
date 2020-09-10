using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class PonudaUserDisplay
    {
        public int Id { get; set; }
        public int PonudaId { get; set; }
        public string NazivPonuda { get; set; }
        public DateTime DatumPolaska { get; set; }
        public string ImePrezime { get; set; }
        public double Cijena { get; set; }
        public string TransakcijaId { get; set; }
        public DateTime VrijemePlacanja { get; set; }
        public string TipSobe { get; set; }
        public int BrojOsoba { get; set; }
        public string Jmbg { get; set; }
        public string DatumRodjenja { get; set; }
        public string Telefon { get; set; }
        public bool IsCanceled { get; set; }

    }
}
