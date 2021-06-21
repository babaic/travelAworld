using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;

namespace eRent.Data
{
    public class Pretplata
    {
        public int PretplataId { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int KategorijaNekretnineId { get; set; }
        public KategorijaNekretnina KategorijaNekretnina { get; set; }
    }
}
