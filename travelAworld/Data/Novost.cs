using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;

namespace eRent.Data
{
    public class Novost
    {
        public int NovostId { get; set; }
        public DateTime Datum { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
