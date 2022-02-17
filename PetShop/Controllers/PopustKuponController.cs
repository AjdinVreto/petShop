using PetShop.Model;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class PopustKuponController : BaseReadController<Model.PopustKupon, object>
    {
        public PopustKuponController(IReadService<PopustKupon, object> service) : base(service)
        {
        }
    }
}
