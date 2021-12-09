using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class ProizvodjacInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public int DrzavaId { get; set; }
    }
}
