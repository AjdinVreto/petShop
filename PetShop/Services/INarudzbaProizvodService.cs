using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public interface INarudzbaProizvodService : ICRUDService<Model.NarudzbaProizvod, NarudzbaProizvodSearchObject, NarudzbaProizvodInsertRequest, NarudzbaProizvodUpdateRequest>
    {
    }
}
