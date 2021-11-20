using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Recenzija
    {
        public int Id { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public int ProizvodId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
