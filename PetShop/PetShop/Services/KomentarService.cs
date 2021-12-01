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
    public class KomentarService : BaseReadService<Model.Komentar, Database.Komentar, KomentarSearchObject>, IKomentarService
    {
        public KomentarService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Komentar> Get(KomentarSearchObject search = null)
        {
            var entity = ctx.Set<Database.Komentar>().AsQueryable();

            if(search?.IncludeKorisnik == true)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            if (search?.IncludeProizvod == true)
            {
                entity = entity.Include(x => x.Proizvod);
            }

            return _mapper.Map<List<Model.Komentar>>(entity);
        }
    }
}
