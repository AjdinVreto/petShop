﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PetShop.Database
{
    public partial class NarudzbaProizvod
    {
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
