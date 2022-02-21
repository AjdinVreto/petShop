using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class TransakcijaInsertRequest
    {
        [Required]
        public decimal Iznos { get; set; }
        [Required]
        public string NacinPlacanja { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public string StripePaymentId { get; set; }
        public int? PopustKuponId { get; set; }
        [Required]
        public int NarudzbaId { get; set; }
    }
}
