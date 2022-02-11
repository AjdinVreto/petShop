using AutoMapper;
using PetShop.Database;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class BaseCRUDService<T, Tdb, TSearch, TInsert, TUpdate> : BaseReadService<T, Tdb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate> where T : class where TSearch : class where Tdb : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public virtual T Insert(TInsert request)
        {
            var set = ctx.Set<Tdb>();

            Tdb entity = _mapper.Map<Tdb>(request);

            set.Add(entity);

            ctx.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var set = ctx.Set<Tdb>();

            var entity = set.Find(id);

            _mapper.Map(request, entity);

            ctx.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Delete(int id)
        {
            var entity = ctx.Set<Tdb>().Find(id);
            ctx.Set<Tdb>().Remove(entity);

            ctx.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
