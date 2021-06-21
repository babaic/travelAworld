using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model
{
    public class NekretninaToDisplayVM
    {
        public int NekretninaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string KategorijaNekretnina { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public decimal Cijena { get; set; }
        public int GodinaIzgradnje { get; set; }
        public double Kvadratura { get; set; }
        public int BrojEtaza { get; set; }
        public int Sprat { get; set; }
        public string Grijanje { get; set; }
        public bool PosjedujeLift { get; set; }
        public bool PosjedujeKlimu { get; set; }
        public bool UkljuceneRezije { get; set; }
        public List<string> Slike { get; set; }
        public int Ocjena { get; set; }
        public int RezervacijaId { get; set; }
        public string Status { get; set; }
        public string Boja { get; set; }
    }
}
