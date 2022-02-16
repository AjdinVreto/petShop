using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class RecenzijaController : BaseCRUDController<Model.Recenzija, object, RecenzijaInsertRequest, RecenzijaUpdateRequest>
    {
        public RecenzijaController(IRecenzijaService service) : base(service)
        {
        }
    }
}
