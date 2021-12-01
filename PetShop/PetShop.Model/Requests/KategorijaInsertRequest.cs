using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class KategorijaInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
    }
}
