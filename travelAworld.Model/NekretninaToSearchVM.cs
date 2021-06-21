using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model
{
    public class NekretninaToSearchVM
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int? KategorijaNekretnineId { get; set; }
        public int? GradId { get; set; }
        public decimal? Cijena { get; set; }
        public int? GodinaIzgradnje { get; set; }
        public float? Kvadratura { get; set; }
        public int? UserId { get; set; }
    }
}
