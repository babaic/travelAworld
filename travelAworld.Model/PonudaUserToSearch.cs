using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class PonudaUserToSearch
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        public int PonudaId { get; set; } = 0;
        public DateTime? Datum { get; set; } = null;
    }
}
