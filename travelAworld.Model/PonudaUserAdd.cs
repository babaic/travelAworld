using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class PonudaUserAdd
    {
        public int PonudaId { get; set; }
        public int UserId { get; set; }
        public double Cijena { get; set; }
        public string TransakcijaId { get; set; }
        public DateTime VrijemePlacanja { get; set; }
        public string TipSobe { get; set; }
        public int BrojOsoba { get; set; }
    }
}
