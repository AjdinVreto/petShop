using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Korisniks = new HashSet<Korisnik>();
            Poslovnicas = new HashSet<Poslovnica>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Korisnik> Korisniks { get; set; }
        public virtual ICollection<Poslovnica> Poslovnicas { get; set; }
    }
}
