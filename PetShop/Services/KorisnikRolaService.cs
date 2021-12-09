using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class KorisnikRolaService : BaseCRUDService<Model.KorisnikRola, Database.KorisnikRola, object, object, object>, IKorisnikRolaService
    {
        public KorisnikRolaService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.KorisnikRola> Get(object search = null)
        {
            var entity = ctx.Set<Database.KorisnikRola>().AsQueryable();

            entity = entity.Include(x => x.Rola);

            var list = entity.ToList();

            return _mapper.Map<List<Model.KorisnikRola>>(list);
        }
    }
}
