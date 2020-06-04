using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelAworld.Data
{
    public class VodicPonuda
    {
        public int Id { get; set; }
        public int VodicId { get; set; }
        public User Vodic { get; set; }
        public int PonudaId { get; set; }
        public Ponuda Ponuda { get; set; }

    }
}
