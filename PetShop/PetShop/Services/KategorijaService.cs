using AutoMapper;
using PetShop.Database;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class KategorijaService : BaseCRUDService<Model.Kategorija, Database.Kategorija, object, KategorijaInsertRequest, object>, IKategorijaService
    {
        public KategorijaService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override Model.Kategorija Insert(KategorijaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Kategorija>(request);
            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Kategorija>(entity);
        }
    }
}
