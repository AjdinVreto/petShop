using PetShop.Model;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class KategorijaController : BaseReadController<Model.Kategorija, object>
    {
        public KategorijaController(IReadService<Kategorija, object> service) : base(service)
        {
        }
    }
}
