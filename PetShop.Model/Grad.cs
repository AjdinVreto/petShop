using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Grad
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
    }
}
