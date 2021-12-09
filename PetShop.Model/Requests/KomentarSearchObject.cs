using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KomentarSearchObject
    {
        public bool? IncludeKorisnik { get; set; }
        public bool? IncludeProizvod { get; set; }
    }
}
