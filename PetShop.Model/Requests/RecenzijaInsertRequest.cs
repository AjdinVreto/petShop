using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class RecenzijaInsertRequest
    {
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public int ProizvodId { get; set; }
    }
}
