using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class PoslovnicaUpdateRequest
    {
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public int GradId { get; set; }
    }
}
