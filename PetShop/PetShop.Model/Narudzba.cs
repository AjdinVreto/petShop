using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Narudzba
    {
        public int Id { get; set; }
        public bool Aktivna { get; set; }
        public bool Zavrsena { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
