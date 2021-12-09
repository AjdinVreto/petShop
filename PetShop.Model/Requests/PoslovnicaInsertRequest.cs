using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class PoslovnicaInsertRequest
    {
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string BrojTelefona { get; set; }
        [Required]
        public int GradId { get; set; }
    }
}
