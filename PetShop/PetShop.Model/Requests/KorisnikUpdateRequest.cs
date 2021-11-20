﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KorisnikUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string Spol { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Token { get; set; }
    }
}
