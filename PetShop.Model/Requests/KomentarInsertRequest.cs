using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KomentarInsertRequest
    {
        [Required]
        public string Tekst { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public int KorisnikId { get; set; }
        [Required]
        public int ProizvodId { get; set; }
    }
}
