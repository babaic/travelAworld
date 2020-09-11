using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class PonudaToSearch
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        public int LokacijaId { get; set; } = 0;
        public DateTime Datum { get; set; } = new DateTime(1990, 12, 10);
        public string Naziv { get; set; }
        public int UserToCheckId { get; set; } = 0;
        public bool PrikaziObrisane { get; set; }
    }
}

