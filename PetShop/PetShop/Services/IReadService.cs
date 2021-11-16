using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public interface IReadService<T, TSearch> where T: class where TSearch: class
    {
        List<T> Get(TSearch search = null);
    }
}
