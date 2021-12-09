using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class ProizvodjacController : BaseCRUDController<Model.Proizvodjac, ProizvodjacSearchObject, ProizvodjacInsertRequest, object>
    {
        public ProizvodjacController(IProizvodjacService service) : base(service)
        {
        }
    }
}
