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
    public class GradController : BaseReadController<Model.Grad, GradSearchObject>
    {
        protected readonly IGradService Service;
        public GradController(IGradService service) : base(service)
        {
            Service = service;
        }

        [HttpGet("getgradovi")]
        public virtual Task<List<Model.Grad>> getGradovi()
        {
            return Service.getGradovi();
        }
    }
}
