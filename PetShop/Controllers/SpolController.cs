using PetShop.Model;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class SpolController : BaseReadController<Model.Spol, object>
    {
        public SpolController(IReadService<Spol, object> service) : base(service)
        {
        }
    }
}
