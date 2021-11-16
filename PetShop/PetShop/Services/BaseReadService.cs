using AutoMapper;
using PetShop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class BaseReadService<T, Tdb, TSearch> : IReadService<T, TSearch> where T: class where Tdb: class where TSearch: class
    {
        public PetShopContext ctx { get; set; }
        protected readonly IMapper _mapper;

        public BaseReadService(PetShopContext context, IMapper mapper)
        {
            ctx = context;
            _mapper = mapper;
        }
        public virtual List<T> Get(TSearch search = null)
        {
            var entity = ctx.Set<Tdb>();

            var list = entity.ToList();

            return _mapper.Map<List<T>>(list);
        }
    }
}
