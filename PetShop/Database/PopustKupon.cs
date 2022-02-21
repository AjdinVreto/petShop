using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class PopustKupon
    {
        public PopustKupon()
        {
            Transakcijas = new HashSet<Transakcija>();
        }

        public int Id { get; set; }
        public int Iznos { get; set; }
        public string Kod { get; set; }

        public virtual ICollection<Transakcija> Transakcijas { get; set; }
    }
}
