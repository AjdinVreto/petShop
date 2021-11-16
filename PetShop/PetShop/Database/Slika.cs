using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Slika
    {
        public Slika()
        {
            Novosts = new HashSet<Novost>();
            Proizvods = new HashSet<Proizvod>();
        }

        public int Id { get; set; }
        public string Putanja { get; set; }

        public virtual ICollection<Novost> Novosts { get; set; }
        public virtual ICollection<Proizvod> Proizvods { get; set; }
    }
}
