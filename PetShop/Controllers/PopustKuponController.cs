using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class PopustKuponController : BaseCRUDController<Model.PopustKupon, PopustKuponSearchRequest, PopustKuponInsertRequest, PopustKuponUpdateRequest>
    {
        public PopustKuponController(IPopustKuponService service) : base(service)
        {

        }
    }
}
