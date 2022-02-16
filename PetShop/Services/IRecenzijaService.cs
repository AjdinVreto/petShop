using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public interface IRecenzijaService : ICRUDService<Model.Recenzija, object, RecenzijaInsertRequest, RecenzijaUpdateRequest>
    {
    }
}
