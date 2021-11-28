using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class NovostController : BaseCRUDController<Model.Novost, NovostSearchObject, NovostInsertRequest, NovostUpdateRequest>
    {
        public NovostController(INovostService service) : base(service)
        {
        }
    }
}
