using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Komentars = new HashSet<Komentar>();
            Kontakts = new HashSet<Kontakt>();
            KorisnikRolas = new HashSet<KorisnikRola>();
            Narudzbas = new HashSet<Narudzba>();
            Novosts = new HashSet<Novost>();
            Recenzijas = new HashSet<Recenzija>();
            Uposleniks = new HashSet<Uposlenik>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public string KorisnickoIme { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Token { get; set; }
        public int GradId { get; set; }
        public int SpolId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual Spol Spol { get; set; }
        public virtual ICollection<Komentar> Komentars { get; set; }
        public virtual ICollection<Kontakt> Kontakts { get; set; }
        public virtual ICollection<KorisnikRola> KorisnikRolas { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
        public virtual ICollection<Novost> Novosts { get; set; }
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
    }
}
