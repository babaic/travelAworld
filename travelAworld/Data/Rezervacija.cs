using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;

namespace eRent.Data
{
    public class Rezervacija
    {
        public int RezervacijaId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int NekretninaId { get; set; }
        public Nekretnina Nekretnina { get; set; }
        public DateTime DatumObilaska { get; set; }
        public DateTime DatumKreiranjaRezervacije { get; set; }
        public string Napomena { get; set; }
        [ForeignKey("Zaposlenik")]
        public int? ZaposlenikId { get; set; }
        public User Zaposlenik { get; set; }
        public string Status { get; set; }
        public DateTime DatumPrijave { get; set; }
        public string VrijemePrijave { get; set; }
        public string VrijemeOdjave { get; set; }
    }
}
