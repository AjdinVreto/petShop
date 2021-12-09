using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class NovostInsertRequest
    {
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string Tekst { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]

        public int KorisnikId { get; set; }
    }
}
