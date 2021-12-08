using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KorisnikSearchObject
    {
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public bool? IncludeGrad { get; set; }
        public bool? IncludeSpol { get; set; }
    }
}
