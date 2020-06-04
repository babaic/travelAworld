using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class UserToSearch
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Role { get; set; }
    }
}
