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
    public class UposlenikService : BaseCRUDService<Model.Uposlenik, Database.Uposlenik, UposlenikSearchObject, UposlenikInsertRequest, UposlenikUpdateRequest>, IUposlenikService
    {
        private readonly IHttpContextAccessor _httpContext;
        public UposlenikService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Uposlenik> Get(UposlenikSearchObject search = null)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = ctx.Set<Database.Uposlenik>().AsQueryable();

            if(search?.IncludeKorisnik == true)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            if (search?.IncludePoslovnica == true)
            {
                entity = entity.Include(x => x.Poslovnica);
            }

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
                throw new Exception("Onemogucen pristup, niste administrator ili uposlenik sistema");
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Uposlenik>>(list);
        }

        public override Model.Uposlenik Insert(UposlenikInsertRequest request)
        {
            bool admin = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = _mapper.Map<Database.Uposlenik>(request);
            ctx.Add(entity);

            if(request.PoslovnicaId == 0)
            {
                throw new UserException("Niste oznacili poslovnicu");
            }

            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator")).ToList();

            foreach (var item in korisniciRole)
            {
                if (item.KorisnikId == userId)
                {
                    admin = true;
                }
            }

            if (!admin)
            {
                throw new Exception("Onemogucena radnja, niste administrator");
            }

            ctx.SaveChanges();

            return _mapper.Map<Model.Uposlenik>(entity);
        }

        public override Model.Uposlenik Update(int id, UposlenikUpdateRequest request)
        {
            bool admin = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = ctx.Uposleniks.Find(id);

            _mapper.Map(request, entity);

            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator")).ToList();

            foreach (var item in korisniciRole)
            {
                if (item.KorisnikId == userId)
                {
                    admin = true;
                }
            }

            if (!admin)
            {
                throw new Exception("Onemogucena radnja, niste administrator");
            }

            ctx.SaveChanges();
            return _mapper.Map<Model.Uposlenik>(entity);
        }
    }
}
