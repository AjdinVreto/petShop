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
    public class ProizvodService : BaseCRUDService<Model.Proizvod, Database.Proizvod, ProizvodSearchObject, ProizvodInsertRequest, ProizvodUpdateRequest>, IProizvodService
    {
        public ProizvodService(PetShopContext context, IMapper mapper) : base(context,mapper)
        {

        }

        public override List<Model.Proizvod> Get(ProizvodSearchObject search = null)
        {
            var entity = ctx.Set<Database.Proizvod>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if (search.KategorijaId.HasValue)
            {
                entity = entity.Where(x => x.KategorijaId == search.KategorijaId);
            }

            if (search.ProizvodjacId.HasValue)
            {
                entity = entity.Where(x => x.ProizvodjacId == search.ProizvodjacId);
            }

            if(search?.IncludeKategorija == true)
            {
                entity = entity.Include(x => x.Kategorija);
            }

            if (search?.IncludeProizvodjac == true)
            {
                entity = entity.Include(x => x.Proizvodjac);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Proizvod>>(list);
        }

    }
}
