using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Proizvodjac
    {
        public Proizvodjac()
        {
            Proizvods = new HashSet<Proizvod>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Proizvod> Proizvods { get; set; }
    }
}
