using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class RezervacijaInfo
    {
        public UsertoDisplay User { get; set; }
        public PonudaUserDisplay PonudaUser { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
    }
}
