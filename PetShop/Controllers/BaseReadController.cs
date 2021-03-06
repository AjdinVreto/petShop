using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseReadController<T, TSearch> : ControllerBase where T: class where TSearch: class
    {
        protected readonly IReadService<T, TSearch> _service;

        public BaseReadController(IReadService<T, TSearch> service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public virtual IList<T> Get([FromQuery]TSearch search)
        {
            return _service.Get(search);
        }

        [Authorize]
        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
