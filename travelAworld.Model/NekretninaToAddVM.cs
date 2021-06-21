using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model
{
    public class NekretninaToAddVM
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int KategorijaNekretnineId { get; set; }
        public int GradId { get; set; }
        public string Adresa { get; set; }
        public double Cijena { get; set; }
        public int GodinaIzgradnje { get; set; }
        public double Kvadratura { get; set; }
        public int BrojEtaza { get; set; }
        public int Sprat { get; set; }
        public string Grijanje { get; set; }
        public bool PosjedujeLift { get; set; }
        public bool PosjedujeKlimu { get; set; }
        public bool UkljuceneRezije { get; set; }
        public List<string> Slike { get; set; }
    }
}
