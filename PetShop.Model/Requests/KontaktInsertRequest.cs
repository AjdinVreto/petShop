using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KontaktInsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Tekst { get; set; }
        [Required]
        public bool Odgovoreno { get; set; }
        [Required]
        public int KorisnikId { get; set; }
    }
}
