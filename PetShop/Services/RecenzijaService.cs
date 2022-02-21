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
    public class RecenzijaService : BaseCRUDService<Model.Recenzija, Database.Recenzija, RecenzijaSearchObject, RecenzijaInsertRequest, RecenzijaUpdateRequest>, IRecenzijaService
    {
        private readonly IHttpContextAccessor _httpContext;
        public RecenzijaService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Recenzija> Get(RecenzijaSearchObject search = null)
        {
            var entity = ctx.Set<Database.Recenzija>().AsQueryable();

            if (search.ProizvodId.HasValue)
            {
                entity = entity.Where(x => x.ProizvodId == search.ProizvodId);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Recenzija>>(list);
        }

        public override Model.Recenzija Insert(RecenzijaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Recenzija>(request);
            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Recenzija>(entity);
        }

        public override Model.Recenzija Update(int id, RecenzijaUpdateRequest request)
        {
            var entity = ctx.Recenzijas.Find(id);

            _mapper.Map(request, entity);

            ctx.SaveChanges();
            return _mapper.Map<Model.Recenzija>(entity);
        }
    }
}
