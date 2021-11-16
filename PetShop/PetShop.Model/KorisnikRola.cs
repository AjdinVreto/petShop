using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class KorisnikRola
    {
        public int KorisnikId { get; set; }
        public int RolaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Rola Rola { get; set; }
    }
}
