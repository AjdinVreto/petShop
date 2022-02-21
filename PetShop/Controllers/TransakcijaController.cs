using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class TransakcijaController : BaseCRUDController<Model.Transakcija, TransakcijaSearchObject, TransakcijaInsertRequest, object>
    {
        public TransakcijaController(ITransakcijaService service) : base(service)
        {

        }
    }
}
