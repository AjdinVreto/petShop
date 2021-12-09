using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class UposlenikInsertRequest
    {
        [Required]
        public DateTime DatumZaposlenja { get; set; }
        [Required]
        public bool Aktivan { get; set; }
        [Required]
        public int KorisnikId { get; set; }
        [Required]
        public int PoslovnicaId { get; set; }
    }
}
