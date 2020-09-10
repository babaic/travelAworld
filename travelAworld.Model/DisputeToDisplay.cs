using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public enum StatusDisputa
    {
        Aktivno,
        Zavrseno
    }
    public class DisputeToDisplay
    {
        public int Id { get; set; }
        public int PonudaUserId { get; set; }
        public double CijenaPonude { get; set; }
        public double IznosPovrata { get; set; }
        public StatusDisputa StatusDisputa { get; set; }
        public DateTime DatumOtkazivanja { get; set; }
        public string DatumZavrsetkaDisputa { get; set; }
    }
}
