using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelAworld.Data
{
    public class PonudaSlike
    {
        public int Id { get; set; }
        public int PonudaId { get; set; }
        public Ponuda Ponuda { get; set; }
        public string SlikaUrl { get; set; }
    }
}
