using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class NarudzbaController : BaseCRUDController<Model.Narudzba, NarudzbaSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>
    {
        public NarudzbaController(INarudzbaService service) : base(service)
        {

        }
    }
}
