using AutoMapper;
using PetShop.Database;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class GradService : BaseReadService<Model.Grad, Database.Grad, GradSearchObject>, IGradService
    {
        public GradService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Grad> Get(GradSearchObject search = null)
        {
            var entity = ctx.Set<Database.Grad>().AsQueryable();

            if(search?.Id > 0)
            {
                entity = ctx.Grads.Where(x => x.DrzavaId == search.Id);
            }

            return _mapper.Map<List<Model.Grad>>(entity);
        }
    }
}
