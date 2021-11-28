using AutoMapper;
using PetShop.Database;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class KontaktService : BaseCRUDService<Model.Kontakt, Database.Kontakt, object, object, KontaktUpdateRequest>, IKontaktService
    {
        public KontaktService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
