using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Requests
{
    public class NarudzbaProizvodInsertRequest
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int NarudzbaId { get; set; }
        [Required]
        public int ProizvodId { get; set; }
        [Required]
        public int Kolicina { get; set; }

    }
}
