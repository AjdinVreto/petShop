﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model
{
    public class Korisnik
    {
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public int OsobaId { get; set; }

        public virtual Osoba Osoba { get; set; }
    }
}
