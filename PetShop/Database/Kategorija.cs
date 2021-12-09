using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Proizvods = new HashSet<Proizvod>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvod> Proizvods { get; set; }
    }
}
