using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class ObavijestToSearch
    {
        public int UserId { get; set; }
        public string Type { get; set; }
        public int PonudaId { get; set; } = 0;
    }
}
