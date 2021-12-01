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
    public class ProizvodjacService : BaseCRUDService<Model.Proizvodjac, Database.Proizvodjac, ProizvodjacSearchObject, ProizvodjacInsertRequest, object>, IProizvodjacService
    {
        public ProizvodjacService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Proizvodjac> Get(ProizvodjacSearchObject search = null)
        {
            var entity = ctx.Set<Database.Proizvodjac>().AsQueryable();

            if(search?.IncludeDrzava == true)
            {
                entity = entity.Include(x => x.Drzava);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Proizvodjac>>(list);
        }

        public override Model.Proizvodjac Insert(ProizvodjacInsertRequest request)
        {
            if(request.DrzavaId == 0)
            {
                throw new UserException("Niste odabrali drzavu");
            }
            var entity = _mapper.Map<Database.Proizvodjac>(request);
            ctx.Add(entity);
            
            ctx.SaveChanges();

            return _mapper.Map<Model.Proizvodjac>(entity);
        }
    }
}
