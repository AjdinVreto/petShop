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
    public class UposlenikService : BaseCRUDService<Model.Uposlenik, Database.Uposlenik, UposlenikSearchObject, UposlenikInsertRequest, UposlenikUpdateRequest>, IUposlenikService
    {
        public UposlenikService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Uposlenik> Get(UposlenikSearchObject search = null)
        {
            var entity = ctx.Set<Database.Uposlenik>().AsQueryable();

            if(search?.IncludeKorisnik == true)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            if (search?.IncludePoslovnica == true)
            {
                entity = entity.Include(x => x.Poslovnica);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Uposlenik>>(list);
        }

        public override Model.Uposlenik Insert(UposlenikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Uposlenik>(request);
            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Uposlenik>(entity);
        }

        public override Model.Uposlenik Update(int id, UposlenikUpdateRequest request)
        {
            var entity = ctx.Uposleniks.Find(id);

            _mapper.Map(request, entity);

            ctx.SaveChanges();
            return _mapper.Map<Model.Uposlenik>(entity);
        }
    }
}
