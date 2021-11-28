using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class UposlenikController : BaseCRUDController<Model.Uposlenik, UposlenikSearchObject, UposlenikInsertRequest, UposlenikUpdateRequest>
    {
        public UposlenikController(IUposlenikService service) : base(service)
        {

        }
    }
}
