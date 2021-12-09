using PetShop.Model;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class KorisnikRolaController : BaseCRUDController<Model.KorisnikRola, object, object, object>
    {
        public KorisnikRolaController(IKorisnikRolaService service) : base(service)
        {
        }
    }
}
