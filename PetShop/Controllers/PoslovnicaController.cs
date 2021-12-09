using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class PoslovnicaController : BaseCRUDController<Model.Poslovnica, PoslovnicaSearchObject, PoslovnicaInsertRequest, PoslovnicaUpdateRequest>
    {
        public PoslovnicaController(IPoslovnicaService service) : base(service)
        {
        }
    }
}
