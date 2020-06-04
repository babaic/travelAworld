using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace travelAworld.Model
{
    public class UserToRegister
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string Role { get; set; }
        public string Adresa { get; set; }
        public DateTime Dob { get; set; }
        public string Telefon { get; set; }
        public byte[] Picture { get; set; }
    }
}
