using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public byte[] Slika { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public int GradId { get; set; }
        public int SpolId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual Spol Spol { get; set; }
        public string GradNaziv => Grad?.Naziv;
        public string SpolNaziv => Spol?.Naziv;

        public virtual ICollection<KorisnikRola> KorisnikRolas { get; set; }
    }
}
