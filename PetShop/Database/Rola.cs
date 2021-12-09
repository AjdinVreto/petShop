using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Rola
    {
        public Rola()
        {
            KorisnikRolas = new HashSet<KorisnikRola>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<KorisnikRola> KorisnikRolas { get; set; }
    }
}
