using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using PetShop.Filters;
using PetShop.Helpers;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class PoslovnicaService : BaseCRUDService<Model.Poslovnica, Database.Poslovnica, PoslovnicaSearchObject, PoslovnicaInsertRequest, PoslovnicaUpdateRequest>, IPoslovnicaService
    {
        private readonly IHttpContextAccessor _httpContext;
        public PoslovnicaService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Poslovnica> Get(PoslovnicaSearchObject search = null)
        {
            var entity = ctx.Set<Database.Poslovnica>().AsQueryable();

            if(search?.IncludeGrad == true)
            {
                entity = entity.Include(x => x.Grad);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Poslovnica>>(list);
        }

        public override Model.Poslovnica Insert(PoslovnicaInsertRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            if (request.GradId == 0)
            {
                throw new UserException("Niste odabrali grad");
            }
            var entity = _mapper.Map<Database.Poslovnica>(request);
            ctx.Add(entity);

            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator") || x.Rola.Naziv.Equals("Uposlenik")).ToList();

            foreach (var item in korisniciRole)
            {
                if (item.KorisnikId == userId)
                {
                    adminUposlenik = true;
                }
            }

            if (!adminUposlenik)
            {
                throw new Exception("Niste administrator ili uposlenik");
            }

            ctx.SaveChanges();

            return _mapper.Map<Model.Poslovnica>(entity);
        }
        public override Model.Poslovnica Update(int id, PoslovnicaUpdateRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = ctx.Poslovnicas.Find(id);

            _mapper.Map(request, entity);

            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator") || x.Rola.Naziv.Equals("Uposlenik")).ToList();

            foreach (var item in korisniciRole)
            {
                if (item.KorisnikId == userId)
                {
                    adminUposlenik = true;
                }
            }

            if (!adminUposlenik)
            {
                throw new Exception("Niste administrator ili uposlenik");
            }

            ctx.SaveChanges();
            return _mapper.Map<Model.Poslovnica>(entity);
        }
    }
}
