using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class KorisnikRola
    {
        public int KorisnikId { get; set; }
        public int RolaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Rola Rola { get; set; }
    }
}
