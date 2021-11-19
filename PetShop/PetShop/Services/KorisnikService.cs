using AutoMapper;
using PetShop.Database;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class KorisnikService : BaseCRUDService<Model.Korisnik, Database.Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>, IKorisnikService
    {
        public KorisnikService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Korisnik> Get(KorisnikSearchObject search = null)
        {
            var entity = ctx.Set<Database.Korisnik>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Email))
            {
                entity = entity.Where(x => x.Email.Contains(search.Email));
            }

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                entity = entity.Where(x => x.KorisnickoIme.Contains(search.KorisnickoIme));
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Korisnik>>(list);
        }
    }
}
