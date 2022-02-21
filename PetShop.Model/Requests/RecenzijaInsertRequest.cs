using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class RecenzijaInsertRequest
    {
        [Required]
        public int Ocjena { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public int KorisnikId { get; set; }
        [Required]
        public int ProizvodId { get; set; }
    }
}
