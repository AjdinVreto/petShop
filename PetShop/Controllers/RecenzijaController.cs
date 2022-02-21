using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class RecenzijaController : BaseCRUDController<Model.Recenzija, RecenzijaSearchObject, RecenzijaInsertRequest, RecenzijaUpdateRequest>
    {
        public RecenzijaController(IRecenzijaService service) : base(service)
        {
        }
    }
}
