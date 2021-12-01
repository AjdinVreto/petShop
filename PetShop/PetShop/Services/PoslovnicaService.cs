using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using PetShop.Filters;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class PoslovnicaService : BaseCRUDService<Model.Poslovnica, Database.Poslovnica, PoslovnicaSearchObject, PoslovnicaInsertRequest, PoslovnicaUpdateRequest>, IPoslovnicaService
    {
        public PoslovnicaService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Poslovnica> Get(PoslovnicaSearchObject search = null)
        {
            var entity = ctx.Set<Database.Poslovnica>().AsQueryable();

            if(search?.IncludeGrad == true)
            {
                entity = entity.Include(x => x.Grad);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Poslovnica>>(list);
        }

        public override Model.Poslovnica Insert(PoslovnicaInsertRequest request)
        {
            if(request.GradId == 0)
            {
                throw new UserException("Niste odabrali grad");
            }
            var entity = _mapper.Map<Database.Poslovnica>(request);
            ctx.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<Model.Poslovnica>(entity);
        }
        public override Model.Poslovnica Update(int id, PoslovnicaUpdateRequest request)
        {
            var entity = ctx.Poslovnicas.Find(id);

            _mapper.Map(request, entity);

            ctx.SaveChanges();
            return _mapper.Map<Model.Poslovnica>(entity);
        }
    }
}
