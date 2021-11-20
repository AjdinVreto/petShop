using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Uposlenik
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
