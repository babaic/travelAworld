using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model
{
    public class StatistikaVM
    {
        public int TrenutnoIzdatihStanova { get; set; }
        public int UkupnoIzdatihStanova { get; set; }
        public int UkupnoZakljucenihUgovora { get; set; }
        public int BrojKorisnika { get; set; }
        public List<TopThree> Top3 { get; set; }
    }

    public class TopThree
    {
        public string NazivNekretnine { get; set; }
        public int UkupnoRentano { get; set; }
    }
}
