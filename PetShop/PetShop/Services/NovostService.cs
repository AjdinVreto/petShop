using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class NovostService : BaseCRUDService<Model.Novost, Database.Novost, NovostSearchObject, NovostInsertRequest, NovostUpdateRequest>, INovostService
    {
        public NovostService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Novost> Get(NovostSearchObject search = null)
        {
            var entity = ctx.Set<Database.Novost>().AsQueryable();

            if (search?.IncludeKorisnik == true)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Novost>>(list);
        }

        public override Model.Novost Insert(NovostInsertRequest request)
        {
            var entity = _mapper.Map<Database.Novost>(request);
            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Novost>(entity);
        }

        public override Model.Novost Update(int id, NovostUpdateRequest request)
        {
            var entity = ctx.Novosts.Find(id);

            _mapper.Map(request, entity);

            ctx.SaveChanges();
            return _mapper.Map<Model.Novost>(entity);
        }
    }
}
