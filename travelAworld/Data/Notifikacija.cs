using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;

namespace eRent.Data
{
    public class Notifikacija
    {
        public int NotifikacijaId { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool Status { get; set; }
        public int? NovostId { get; set; }
        public Novost Novost { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Naziv { get; set; }
    }
}
