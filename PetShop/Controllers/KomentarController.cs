using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class KomentarController : BaseCRUDController<Model.Komentar, KomentarSearchObject, KomentarInsertRequest, KomentarUpdateRequest>
    {
        public KomentarController(IKomentarService service) : base(service)
        {
        }
    }
}
