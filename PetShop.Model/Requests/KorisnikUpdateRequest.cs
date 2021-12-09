using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KorisnikUpdateRequest
    {
        public byte[] Slika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public int GradId { get; set; }
    }
}
