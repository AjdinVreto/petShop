using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class KomentarController : BaseReadController<Model.Komentar, KomentarSearchObject>
    {
        public KomentarController(IKomentarService service) : base(service)
        {

        }
    }
}
