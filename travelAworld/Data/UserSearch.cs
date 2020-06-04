using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelAworld.Data
{
    public class UserSearch
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string rDrzava { get; set; }
        public string rMjesto { get; set; }
        public DateTime rMjesec { get; set; }
        public float rCijena { get; set; }
        public DateTime DatumPretrage { get; set; } = DateTime.Now;
    }
}
