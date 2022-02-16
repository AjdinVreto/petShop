using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class KontaktController : BaseCRUDController<Model.Kontakt, object, KontaktInsertRequest, KontaktUpdateRequest>
    {
        public KontaktController(IKontaktService service) : base(service)
        {
        }
    }
}
