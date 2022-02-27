using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KorisnikInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PotvrdaPassword { get; set; }
        public int GradId { get; set; }
        public int SpolId { get; set; }
        public List<int> Role { get; set; } = new List<int>();

    }
}
