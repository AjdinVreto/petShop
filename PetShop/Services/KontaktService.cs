using AutoMapper;
using PetShop.Database;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class KontaktService : BaseCRUDService<Model.Kontakt, Database.Kontakt, object, KontaktInsertRequest, KontaktUpdateRequest>, IKontaktService
    {
        public KontaktService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override Model.Kontakt Insert(KontaktInsertRequest request)
        {
            var entity = _mapper.Map<Database.Kontakt>(request);

            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Kontakt>(entity);
        }
    }
}
