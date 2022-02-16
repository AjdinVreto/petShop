using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KorisnikInsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PotvrdaPassword { get; set; }
        [Required]
        public int GradId { get; set; }
        [Required]
        public int SpolId { get; set; }
        public List<int> Role { get; set; } = new List<int>();

    }
}
