using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class KategorijaController : BaseCRUDController<Model.Kategorija, object, KategorijaInsertRequest, object>
    {
        public KategorijaController(IKategorijaService service) : base(service)
        {
        }
    }
}
