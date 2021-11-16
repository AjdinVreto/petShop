using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string Spol { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
    }
}
