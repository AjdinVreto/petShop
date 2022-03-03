using Microsoft.AspNetCore.Mvc;
using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class ZivotinjaController : BaseReadController<Model.Zivotinja, object>
    {
        public ZivotinjaController(IReadService<Zivotinja, object> service) : base(service)
        {
        }
    }
}
