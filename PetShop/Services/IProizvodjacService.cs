using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public interface IProizvodjacService : ICRUDService<Model.Proizvodjac, ProizvodjacSearchObject, ProizvodjacInsertRequest, object>
    {
    }
}
