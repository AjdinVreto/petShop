using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IReadService<T, TSearch> where T:class where TSearch:class where TUpdate: class where TInsert:class
    {
        T Insert(TInsert request);
        T Update(int id, TUpdate request);
        T Delete(int id);
    }
}
