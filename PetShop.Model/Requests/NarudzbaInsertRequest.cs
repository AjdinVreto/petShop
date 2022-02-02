using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class NarudzbaInsertRequest
    {
        [Required]
        public bool Aktivna { get; set; }
        [Required]
        public bool Zavrsena { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public int KorisnikId { get; set; }
    }
}
