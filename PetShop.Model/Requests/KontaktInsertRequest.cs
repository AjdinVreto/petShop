using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KontaktInsertRequest
    {
        public string Ime { get; set; }
        public string Email { get; set; }
        public string Tekst { get; set; }
        public bool Odgovoreno { get; set; }
        public int KorisnikId { get; set; }
    }
}
