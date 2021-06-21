using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;

namespace eRent.Data
{
    public class Ugovor
    {
        public int UgovorId { get; set; }
        public int KlijentId { get; set; }
        public User Klijent { get; set; }
        public int KorisnikId { get; set; }
        public User Korisnik { get; set; }
        public int NekretninaId { get; set; }
        public Nekretnina Nekretnina { get; set; }
        public DateTime PocetakKoristenja { get; set; }
        public DateTime KrajKoristenja { get; set; }
        public decimal Cijena { get; set; }
    }
}
