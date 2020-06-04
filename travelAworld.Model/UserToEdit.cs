using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class UserToEdit
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Adresa { get; set; }
        public DateTime Dob { get; set; }
        public byte[] Picture { get; set; }

    }
}
