using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseReadController<T, TSearch> where T: class where TSearch: class where TInsert:class where TUpdate:class
    {
        protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudService;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _crudService = service;
        }

        [Authorize]
        [HttpPost]
        public T Insert([FromBody] TInsert request)
        {
            return _crudService.Insert(request);
        }

        [Authorize]
        [HttpPut("{id}")]
        public T Update(int id, [FromBody] TUpdate request)
        {
            return _crudService.Update(id, request);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public T Delete(int id)
        {
            return _crudService.Delete(id);
        }
    }
}
