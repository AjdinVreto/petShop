using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KorisnikUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public byte[] Slika { get; set; }
        public string KorisnickoIme { get; set; }
        public int GradId { get; set; }
    }
}
