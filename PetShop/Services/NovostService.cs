using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using PetShop.Helpers;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class NovostService : BaseCRUDService<Model.Novost, Database.Novost, NovostSearchObject, NovostInsertRequest, NovostUpdateRequest>, INovostService
    {
        private readonly IHttpContextAccessor _httpContext;
        public NovostService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Novost> Get(NovostSearchObject search = null)
        {
            var entity = ctx.Set<Database.Novost>().AsQueryable();

            entity = entity.Include(x => x.Korisnik);

            entity = entity.OrderByDescending(x => x.Id).Take(10);

            var list = entity.ToList();

            return _mapper.Map<List<Model.Novost>>(list);
        }

        public override Model.Novost Insert(NovostInsertRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = _mapper.Map<Database.Novost>(request);
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

            return _mapper.Map<Model.Novost>(entity);
        }

        public override Model.Novost Update(int id, NovostUpdateRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = ctx.Novosts.Find(id);

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
            return _mapper.Map<Model.Novost>(entity);
        }
    }
}
