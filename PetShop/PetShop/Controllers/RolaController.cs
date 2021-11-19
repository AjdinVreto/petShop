using PetShop.Model;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class RolaController : BaseReadController<Model.Rola, object>
    {
        public RolaController(IReadService<Rola, object> service) : base(service)
        {
        }
    }
}
