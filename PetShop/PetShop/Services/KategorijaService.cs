using AutoMapper;
using Microsoft.AspNetCore.Http;
using PetShop.Database;
using PetShop.Helpers;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class KategorijaService : BaseCRUDService<Model.Kategorija, Database.Kategorija, object, KategorijaInsertRequest, object>, IKategorijaService
    {
        private readonly IHttpContextAccessor _httpContext;
        public KategorijaService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override Model.Kategorija Insert(KategorijaInsertRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = _mapper.Map<Database.Kategorija>(request);
            ctx.Add(entity);

            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator") || x.Rola.Naziv.Equals("Uposlenik")).ToList();

            foreach (var item in korisniciRole)
            {
                if (item.KorisnikId == userId)
                {
                    adminUposlenik = true;
                }
            }

            if (!adminUposlenik)
            {
                throw new Exception("Niste administrator ili uposlenik");
            }

            ctx.SaveChanges();

            return _mapper.Map<Model.Kategorija>(entity);
        }
    }
}
