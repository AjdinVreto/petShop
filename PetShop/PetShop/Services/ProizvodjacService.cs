using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using PetShop.Filters;
using PetShop.Helpers;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class ProizvodjacService : BaseCRUDService<Model.Proizvodjac, Database.Proizvodjac, ProizvodjacSearchObject, ProizvodjacInsertRequest, object>, IProizvodjacService
    {
        private readonly IHttpContextAccessor _httpContext;
        public ProizvodjacService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
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
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            if (request.DrzavaId == 0)
            {
                throw new UserException("Niste odabrali drzavu");
            }
            var entity = _mapper.Map<Database.Proizvodjac>(request);
            ctx.Add(entity);

            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator") || x.Rola.Naziv.Equals("Uposlenik")).ToList();

            foreach (var item in korisniciRole)
            {
                if (item.KorisnikId == userId)
                {
                    adminUposlenik = true;
                }
            }

            if (!adminUposlenik)
            {
                throw new Exception("Niste administrator ili uposlenik");
            }

            ctx.SaveChanges();

            return _mapper.Map<Model.Proizvodjac>(entity);
        }
    }
}
