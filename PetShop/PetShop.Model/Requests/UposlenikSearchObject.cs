using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class UposlenikSearchObject
    {
        public DateTime DatumZaposlenja { get; set; }
        public bool Aktivan { get; set; }
        public bool? IncludeKorisnik { get; set; }
        public bool? IncludePoslovnica { get; set; }

    }
}
