using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Drzava
    {
        public Drzava()
        {
            Grads = new HashSet<Grad>();
            Proizvodjacs = new HashSet<Proizvodjac>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Grad> Grads { get; set; }
        public virtual ICollection<Proizvodjac> Proizvodjacs { get; set; }
    }
}
