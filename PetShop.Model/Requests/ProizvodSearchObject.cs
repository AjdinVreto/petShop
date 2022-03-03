using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class ProizvodSearchObject
    {
        public string Naziv { get; set; }
        public int? KategorijaId { get; set; }
        public int? ProizvodjacId { get; set; }
        public int? ZivotinjaId { get; set; }
    }
}
