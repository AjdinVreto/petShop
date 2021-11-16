using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Poslovnica
    {
        public int Id { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
    }
}
