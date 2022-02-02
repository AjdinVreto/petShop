using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class NarudzbaProizvodSearchObject
    {
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
    }
}
