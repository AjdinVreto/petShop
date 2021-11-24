using PetShop.Model;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class ProizvodjacController : BaseReadController<Model.Proizvodjac, object>
    {
        public ProizvodjacController(IReadService<Proizvodjac, object> service) : base(service)
        {
        }
    }
}
