using eRent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;

namespace eRent.Data
{
    public class Nekretnina
    {
        public int NekretninaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int KategorijaNekretninaId { get; set; }
        public KategorijaNekretnina KategorijaNekretnina { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public string Adresa { get; set; }
        public decimal Cijena { get; set; }
        public int GodinaIzgradnje { get; set; }
        public double Kvadratura { get; set; }
        public int BrojEtaza { get; set; }
        public int Sprat { get; set; }
        public string Grijanje { get; set; }
        public bool PosjedujeLift { get; set; }
        public bool PosjedujeKlimu { get; set; }
        public bool UkljuceneRezije { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
