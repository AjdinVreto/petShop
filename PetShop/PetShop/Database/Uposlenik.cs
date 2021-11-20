using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Uposlenik
    {
        public int Id { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public bool Aktivan { get; set; }
        public int KorisnikId { get; set; }
        public int PoslovnicaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
    }
}
