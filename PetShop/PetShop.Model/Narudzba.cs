using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Narudzba
    {
        public int Id { get; set; }
        public bool Aktivna { get; set; }
        public bool Zavrsena { get; set; }
        public DateTime Datum { get; set; }
        public int OsobaId { get; set; }

        public virtual Osoba Osoba { get; set; }
    }
}
