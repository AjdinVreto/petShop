﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class Osoba
    {
        public Osoba()
        {
            Komentars = new HashSet<Komentar>();
            Kontakts = new HashSet<Kontakt>();
            Korisniks = new HashSet<Korisnik>();
            Narudzbas = new HashSet<Narudzba>();
            Novosts = new HashSet<Novost>();
            Recenzijas = new HashSet<Recenzija>();
            Uposleniks = new HashSet<Uposlenik>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string Spol { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Komentar> Komentars { get; set; }
        public virtual ICollection<Kontakt> Kontakts { get; set; }
        public virtual ICollection<Korisnik> Korisniks { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
        public virtual ICollection<Novost> Novosts { get; set; }
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
    }
}
