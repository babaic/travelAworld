using System;
using System.Collections.Generic;
using System.Text;

namespace travelAworld.Model
{
    public class UsertoDisplay
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public byte[] ProfilePic { get; set; }
        //public string DisplayRole { get; set; }
    }
}
