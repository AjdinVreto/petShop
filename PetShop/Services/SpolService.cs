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
    public class SpolService : BaseReadService<Model.Spol, Database.Spol, object>, ISpolService
    {
        public SpolService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<Model.Spol>> getSpolovi()
        {
            var entity = await ctx.Spols.ToListAsync();

            return _mapper.Map<List<Model.Spol>>(entity);
        }
    }
}
