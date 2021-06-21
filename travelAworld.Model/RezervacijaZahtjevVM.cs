using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model
{
    public class RezervacijaZahtjevVM
    {
        public int NekretninaId { get; set; }
        public string Naziv { get; set; }
        public string KategorijaNekretnina { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public decimal Cijena { get; set; }
        public int Sprat { get; set; }
        public List<string> Slike { get; set; }
        public int RezervacijaId { get; set; }
        public string Status { get; set; }
        public string KorisnikIznajmio { get; set; }
        public int KlijentId { get; set; }
        public double Uplaceno { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string EmailSadrzaj { get; set; }
    }
}
