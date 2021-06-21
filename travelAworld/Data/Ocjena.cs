using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;

namespace eRent.Data
{
    public class Ocjena
    {
        public int OcjenaId { get; set; }
        public int NekretninaId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Datum { get; set; }
        public int Vrijednost { get; set; }
    }
}
