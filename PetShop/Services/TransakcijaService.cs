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
    public class TransakcijaService : BaseCRUDService<Model.Transakcija, Database.Transakcija, TransakcijaSearchObject, TransakcijaInsertRequest, object>, ITransakcijaService
    {
        private readonly IHttpContextAccessor _httpContext;
        public TransakcijaService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Transakcija> Get(TransakcijaSearchObject search = null)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = ctx.Set<Database.Transakcija>().AsQueryable();
            entity = entity.Include(x => x.Narudzba).Include(x => x.Narudzba.Korisnik);

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

            return _mapper.Map<List<Model.Transakcija>>(list);
        }

        public override Model.Transakcija Insert(TransakcijaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Transakcija>(request);
            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Transakcija>(entity);
        }
    }
}
