using PetShop.Model;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class DrzavaController : BaseReadController<Model.Drzava, object>
    {
        public DrzavaController(IReadService<Drzava, object> service) : base(service)
        {
        }
    }
}
