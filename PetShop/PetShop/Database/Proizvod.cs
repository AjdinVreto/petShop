using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Proizvod
    {
        public Proizvod()
        {
            Komentars = new HashSet<Komentar>();
            NarudzbaProizvods = new HashSet<NarudzbaProizvod>();
            Recenzijas = new HashSet<Recenzija>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public int KategorijaId { get; set; }
        public int ProizvodjacId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Proizvodjac Proizvodjac { get; set; }
        public virtual ICollection<Komentar> Komentars { get; set; }
        public virtual ICollection<NarudzbaProizvod> NarudzbaProizvods { get; set; }
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
    }
}
