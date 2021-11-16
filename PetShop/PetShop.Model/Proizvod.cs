using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public int SlikaId { get; set; }
        public int KategorijaId { get; set; }
        public int ProizvodjacId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Proizvodjac Proizvodjac { get; set; }
        public virtual Slika Slika { get; set; }
    }
}
