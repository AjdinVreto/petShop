using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Novost
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public byte[] Slika { get; set; }
     
        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
