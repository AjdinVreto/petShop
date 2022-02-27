using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class NovostInsertRequest
    {
        public string Naslov { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }
    }
}
