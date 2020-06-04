using System;
using System.Collections.Generic;
using System.Text;
using travelAworld.Data;

namespace travelAworld.Dtos
{
    public class UsertoDisplay
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public List<Role> Roles { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
    }
}
