using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelAworld.Data
{
    public class PonudaUser
    {
        public int Id { get; set; }
        public int PonudaId { get; set; }
        public Ponuda Ponuda { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public double Cijena { get; set; }
        public string TransakcijaId { get; set; }
        public DateTime VrijemePlacanja { get; set; }
        public string TipSobe { get; set; }
        public int BrojOsoba { get; set; }
        public bool IsCanceled { get; set; } = false;
    }
}
