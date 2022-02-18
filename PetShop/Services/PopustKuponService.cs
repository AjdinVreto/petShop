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
    public class PopustKuponService : BaseCRUDService<Model.PopustKupon, Database.PopustKupon, PopustKuponSearchRequest, PopustKuponInsertRequest, PopustKuponUpdateRequest>, IPopustKuponService
    {
        private readonly IHttpContextAccessor _httpContext;
        public PopustKuponService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.PopustKupon> Get(PopustKuponSearchRequest search = null)
        {
            var entity = ctx.Set<Database.PopustKupon>().AsQueryable();

            var list = entity.ToList();

            return _mapper.Map<List<Model.PopustKupon>>(list);
        }

        public override Model.PopustKupon Insert(PopustKuponInsertRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = _mapper.Map<Database.PopustKupon>(request);
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

            return _mapper.Map<Model.PopustKupon>(entity);
        }
        public override Model.PopustKupon Update(int id, PopustKuponUpdateRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = ctx.PopustKupons.Find(id);

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
            return _mapper.Map<Model.PopustKupon>(entity);
        }
    }
}
