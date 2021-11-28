using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public interface IUposlenikService : ICRUDService<Model.Uposlenik, UposlenikSearchObject, UposlenikInsertRequest, UposlenikUpdateRequest>
    {
    }
}
