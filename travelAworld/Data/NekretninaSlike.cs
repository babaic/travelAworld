using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Data
{
    public class NekretninaSlike
    {
        public int Id { get; set; }
        public int NekretninaId { get; set; }
        public Nekretnina Nekretnina { get; set; }
        public string SlikaUrl { get; set; }
    }
}
