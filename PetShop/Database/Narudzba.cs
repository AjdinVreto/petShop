using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            NarudzbaProizvods = new HashSet<NarudzbaProizvod>();
            Transakcijas = new HashSet<Transakcija>();
        }

        public int Id { get; set; }
        public bool Aktivna { get; set; }
        public bool Zavrsena { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<NarudzbaProizvod> NarudzbaProizvods { get; set; }
        public virtual ICollection<Transakcija> Transakcijas { get; set; }
    }
}
