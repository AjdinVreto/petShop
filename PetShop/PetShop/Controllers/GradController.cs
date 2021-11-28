using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class GradController : BaseReadController<Model.Grad, GradSearchObject>
    {
        public GradController(IGradService service) : base(service)
        {

        }
    }
}
