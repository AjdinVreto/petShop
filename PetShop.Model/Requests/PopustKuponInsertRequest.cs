using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class PopustKuponInsertRequest
    {
        [Required]
        public int Iznos { get; set; }
        [Required]
        public string Kod { get; set; }
    }
}
