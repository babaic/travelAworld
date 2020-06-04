using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelAworld.Data
{
    public class Obavijesti
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PonudaId { get; set; }
        public Ponuda Ponuda { get; set; }
        public string Tekst { get; set; }
        public string Type { get; set; } // notifikacija, poruka

        public Obavijesti()
        {
            Datum = DateTime.Now;
        }
    }
}
