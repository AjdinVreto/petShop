using Microsoft.AspNetCore.Mvc;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class ProizvodController : BaseCRUDController<Model.Proizvod, ProizvodSearchObject, ProizvodInsertRequest, ProizvodUpdateRequest>
    {
        protected new readonly IProizvodService _service;
        public ProizvodController(IProizvodService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("Recommend/{id}")]
        public List<Model.Proizvod> Recommend(int id)
        {
            return _service.Recommend(id);
        }
    }
}
