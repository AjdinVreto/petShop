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
        public bool? IncludeKategorija { get; set; }
        public bool? IncludeProizvodjac { get; set; }
    }
}
