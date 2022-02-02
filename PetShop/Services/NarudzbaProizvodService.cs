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
    public class NarudzbaProizvodService : BaseCRUDService<Model.NarudzbaProizvod, Database.NarudzbaProizvod, NarudzbaProizvodSearchObject, NarudzbaProizvodInsertRequest, NarudzbaProizvodUpdateRequest>, INarudzbaProizvodService
    {
        private readonly IHttpContextAccessor _httpContext;
        public NarudzbaProizvodService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.NarudzbaProizvod> Get(NarudzbaProizvodSearchObject search = null)
        {
            var entity = ctx.Set<Database.NarudzbaProizvod>().AsQueryable();

            var list = entity.ToList();

            return _mapper.Map<List<Model.NarudzbaProizvod>>(list);
        }

        public override Model.NarudzbaProizvod Insert(NarudzbaProizvodInsertRequest request)
        {
            var entity = _mapper.Map<Database.NarudzbaProizvod>(request);
            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.NarudzbaProizvod>(entity);
        }

        public override Model.NarudzbaProizvod Update(int id, NarudzbaProizvodUpdateRequest request)
        {
            var entity = ctx.NarudzbaProizvods.Where(x => x.NarudzbaId == id).FirstOrDefault();

            _mapper.Map(request, entity);

            ctx.SaveChanges();
            return _mapper.Map<Model.NarudzbaProizvod>(entity);
        }

    }
}
