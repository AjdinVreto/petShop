using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Poslovnica
    {
        public Poslovnica()
        {
            Uposleniks = new HashSet<Uposlenik>();
        }

        public int Id { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
    }
}
