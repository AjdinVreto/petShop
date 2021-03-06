using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Kontakt
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Email { get; set; }
        public string Tekst { get; set; }
        public bool Odgovoreno { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
