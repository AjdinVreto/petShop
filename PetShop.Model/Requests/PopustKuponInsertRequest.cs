using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Model.Requests
{
    public class PopustKuponInsertRequest
    {
        public int Iznos { get; set; }
        public string Kod { get; set; }
    }
}
