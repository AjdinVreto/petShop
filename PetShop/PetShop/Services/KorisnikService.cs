using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using PetShop.Filters;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class KorisnikService : BaseCRUDService<Model.Korisnik, Database.Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>, IKorisnikService
    {
        public KorisnikService(PetShopContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Korisnik> Get(KorisnikSearchObject search = null)
        {
            var entity = ctx.Set<Database.Korisnik>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.KorisnickoIme) || !string.IsNullOrWhiteSpace(search?.Email))
            {
                entity = entity.Where(x => x.KorisnickoIme.Contains(search.KorisnickoIme) || x.Email.Contains(search.Email));
            }

            if(search?.IncludeGrad == true)
            {
                entity = entity.Include(x => x.Grad);
            }

            if (search?.IncludeSpol == true)
            {
                entity = entity.Include(x => x.Spol);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public override Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);
            ctx.Add(entity);

            if(request.Password != request.PotvrdaPassword)
            {
                throw new UserException("Lozinka nije ispravna");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            entity.Token = "token";

            ctx.SaveChanges();

            foreach(var item in request.Role)
            {
                Database.KorisnikRola korisniciRole = new KorisnikRola();
                korisniciRole.KorisnikId = entity.Id;
                korisniciRole.RolaId = item;

                ctx.KorisnikRolas.Add(korisniciRole);
            }

            ctx.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public override Model.Korisnik Update(int id, KorisnikUpdateRequest request)
        {
            var entity = ctx.Korisniks.Find(id);

            _mapper.Map(request, entity);

            ctx.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
