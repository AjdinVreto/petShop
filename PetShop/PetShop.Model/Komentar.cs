using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Komentar
    {
        public int Id { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public int ProizvodId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
