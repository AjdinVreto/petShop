using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            KorisnikRolas = new HashSet<KorisnikRola>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Token { get; set; }
        public int OsobaId { get; set; }

        public virtual Osoba Osoba { get; set; }
        public virtual ICollection<KorisnikRola> KorisnikRolas { get; set; }
    }
}
