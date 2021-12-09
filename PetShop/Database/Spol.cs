using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Spol
    {
        public Spol()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
