using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class TransakcijaInsertRequest
    {
        public decimal Iznos { get; set; }
        public string NacinPlacanja { get; set; }
        public DateTime Datum { get; set; }
        public string StripePaymentId { get; set; }
        public int? PopustKuponId { get; set; }
        public int NarudzbaId { get; set; }
    }
}
