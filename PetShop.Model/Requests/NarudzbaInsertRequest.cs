﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class NarudzbaInsertRequest
    {
        public bool Aktivna { get; set; }
        public bool Zavrsena { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
    }
}
