using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class UposlenikInsertRequest
    {
        public DateTime DatumZaposlenja { get; set; }
        public bool Aktivan { get; set; }
        public int KorisnikId { get; set; }
        public int PoslovnicaId { get; set; }
    }
}
