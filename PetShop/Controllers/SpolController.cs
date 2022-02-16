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
    public class SpolController : BaseReadController<Model.Spol, object>
    {
        protected readonly ISpolService Service;
        public SpolController(ISpolService service) : base(service)
        {
            Service = service;
        }

        [HttpGet("getspolovi")]
        public virtual Task<List<Model.Spol>> getSpolovi()
        {
            return Service.getSpolovi();
        }
    }
}
