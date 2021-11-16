using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Transakcija
    {
        public int Id { get; set; }
        public decimal Iznos { get; set; }
        public string NacinPlacanja { get; set; }
        public DateTime Datum { get; set; }
        public int PopustKuponId { get; set; }
        public int NarudzbaId { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public virtual PopustKupon PopustKupon { get; set; }
    }
}
