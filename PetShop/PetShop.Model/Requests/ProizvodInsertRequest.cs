using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class ProizvodInsertRequest
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public int SlikaId { get; set; }
        public int KategorijaId { get; set; }
        public int ProizvodjacId { get; set; }
    }
}
