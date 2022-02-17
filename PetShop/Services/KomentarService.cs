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
    public class KomentarService : BaseCRUDService<Model.Komentar, Database.Komentar, KomentarSearchObject, KomentarInsertRequest, KomentarUpdateRequest>, IKomentarService
    {
        public KomentarService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Komentar> Get(KomentarSearchObject search = null)
        {
            var entity = ctx.Set<Database.Komentar>().AsQueryable();

            entity = entity.Include(x => x.Korisnik).Include(x => x.Proizvod);

            var list = entity.ToList();

            return _mapper.Map<List<Model.Komentar>>(list);
        }

        public override Model.Komentar Insert(KomentarInsertRequest request)
        {
            var entity = _mapper.Map<Database.Komentar>(request);

            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Komentar>(entity);
        }
    }
}
