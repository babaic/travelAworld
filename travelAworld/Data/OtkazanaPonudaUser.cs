using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelAworld.Data
{
    public enum StatusDisputa
    {
        Aktivno,
        Zavrseno
    }
    public class OtkazanaPonudaUser
    {
        public int Id { get; set; }
        public int PonudaUserId { get; set; }
        public PonudaUser PonudaUser { get; set; }
        public double CijenaPonude { get; set; }
        public double IznosPovrata { get; set; }
        public StatusDisputa StatusDisputa { get; set; }
        public DateTime DatumOtkazivanja { get; set; }
        public DateTime? DatumZavrsetkaDisputa { get; set; }
    }
}
