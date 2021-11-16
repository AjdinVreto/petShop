using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Osobas = new HashSet<Osoba>();
            Poslovnicas = new HashSet<Poslovnica>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Osoba> Osobas { get; set; }
        public virtual ICollection<Poslovnica> Poslovnicas { get; set; }
    }
}
