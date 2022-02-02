using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class NarudzbaProizvodController : BaseCRUDController<Model.NarudzbaProizvod, NarudzbaProizvodSearchObject, NarudzbaProizvodInsertRequest, NarudzbaProizvodUpdateRequest>
    {
        public NarudzbaProizvodController(INarudzbaProizvodService service) : base(service)
        {

        }
    }
}
