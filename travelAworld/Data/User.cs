using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelAworld.Data
{
    public class User : IdentityUser<int>
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public byte[] Slika { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
