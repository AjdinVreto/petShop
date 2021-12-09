using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class ProizvodInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]
        public int KategorijaId { get; set; }
        [Required]
        public int ProizvodjacId { get; set; }
    }
}
