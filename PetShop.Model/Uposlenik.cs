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
        public string KorisnikIme => Korisnik?.Ime;
        public string KorisnikPrezime => Korisnik?.Prezime;
        public string KorisnikEmail => Korisnik?.Email;
        public string KorisnikKorisnickoIme => Korisnik?.KorisnickoIme;
        public string PoslovnicaAdresa => Poslovnica?.Adresa;
    }
}
