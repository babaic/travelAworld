using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class PaymentCardAdd
    {
        public string BrojKartice { get; set; }
        public int Mjesec { get; set; }
        public int Godina { get; set; }
        public int CVV { get; set; }
        public string ImePrezime { get; set; }
        public long Amount { get; set; }
        public string Desc { get; set; }
    }
}
