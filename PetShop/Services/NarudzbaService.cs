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
    public class NarudzbaService : BaseCRUDService<Model.Narudzba, Database.Narudzba, NarudzbaSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>, INarudzbaService
    {
        private readonly IHttpContextAccessor _httpContext;
        public NarudzbaService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Narudzba> Get(NarudzbaSearchObject search = null)
        {
            var entity = ctx.Set<Database.Narudzba>().AsQueryable();

            if (search?.IncludeKorisnik == true)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Narudzba>>(list);
        }

        public override Model.Narudzba Insert(NarudzbaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Narudzba>(request);
            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Narudzba>(entity);
        }

        public override Model.Narudzba Update(int id, NarudzbaUpdateRequest request)
        {
            var entity = ctx.Narudzbas.Find(id);

            _mapper.Map(request, entity);

            ctx.SaveChanges();
            return _mapper.Map<Model.Narudzba>(entity);
        }

    }
}
