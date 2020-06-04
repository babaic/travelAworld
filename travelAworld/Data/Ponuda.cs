using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace travelAworld.Data
{
    public class Ponuda
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime DatumPovratka { get; set; }
        public float Cijena { get; set; }
        public string CijenaUkljuceno { get; set; }
        public string CijenaIskljuceno { get; set; }
        public string Napomena { get; set; }
        public string Hotel { get; set; }
        public int LokacijaId { get; set; }
        public Lokacija Lokacija { get; set; }
        public DateTime DatumObjave { get; set; }
        public bool IsActive { get; set; }
        public string Koordinata1 { get; set; }
        public string Koordinata2 { get; set; }
        // int ObjavioId { get; set; }
        //public User ObjavioPonudu { get; set; }

        public Ponuda()
        {
            DatumObjave = DateTime.Now;
            IsActive = true;
            //ObjavioId = Int32.Parse(objavioId);
        }
    }
    
}
