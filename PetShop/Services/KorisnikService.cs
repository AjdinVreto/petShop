using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.Database;
using PetShop.Filters;
using PetShop.Helpers;
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
        private readonly IHttpContextAccessor _httpContext;
        public KorisnikService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpcontext) : base(context, mapper)
        {
            _httpContext = httpcontext;
        }

        public override List<Model.Korisnik> Get(KorisnikSearchObject search = null)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = ctx.Set<Database.Korisnik>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.KorisnickoIme) || !string.IsNullOrWhiteSpace(search?.Email))
            {
                entity = entity.Where(x => x.KorisnickoIme.Contains(search.KorisnickoIme) || x.Email.Contains(search.Email));
            }

            entity = entity.Include(x => x.Spol).Include(x => x.Grad);

            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator") || x.Rola.Naziv.Equals("Uposlenik")).ToList();

            foreach(var item in korisniciRole)
            {
                if(item.KorisnikId == userId)
                {
                    adminUposlenik = true;
                }
            }

            if(!adminUposlenik)
            {
                throw new Exception("Onemogucen pristup, niste administrator sistema");
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public override Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);
            var korisnici = ctx.Korisniks.ToList();

            foreach(var item in korisnici)
            {
                if (item.KorisnickoIme.Equals(request.KorisnickoIme))
                {
                    throw new UserException("Korisnicko ime vec postoji");
                }

                if (item.Email.Equals(request.Email))
                {
                    throw new UserException("Email vec postoji");
                }
            }

            ctx.Add(entity);

            if(request.GradId == 0 || request.SpolId == 0)
            {
                throw new UserException("Niste oznacili grad ili spol");
            }

            if(request.Password != request.PotvrdaPassword)
            {
                throw new UserException("Lozinka nije ispravna");
            }

            foreach(var item in korisnici)
            {
                if(item.KorisnickoIme.Equals(request.KorisnickoIme) || item.Email.Equals(request.Email))
                {
                    throw new UserException("Korisnicko ime ili email vec postoji");
                }
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

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
            var korisnici = ctx.Korisniks.ToList();

            foreach (var item in korisnici)
            {
                if (item.Email.Equals(request.Email) && item.Id != id) 
                {
                    throw new UserException("Email vec postoji");
                }
                if(item.KorisnickoIme.Equals(request.KorisnickoIme) && item.Id != id)
                {
                    throw new UserException("Korisnicko ime vec postoji");
                }
            }

            if(request.Password != null)
            {
                string passwordSalt = GenerateSalt();
                entity.PasswordSalt = passwordSalt;
                entity.PasswordHash = GenerateHash(passwordSalt, request.Password);
            }

            _mapper.Map(request, entity);
            entity.Password = null;

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

        public async Task<Model.Korisnik> Login(string username, string password)
        {
            var entity = await ctx.Korisniks.Include("KorisnikRolas.Rola").Include(x => x.Spol).Include(x => x.Grad).FirstOrDefaultAsync(x => x.KorisnickoIme == username);

            if(entity == null)
            {
                throw new Exception("Pogresan username ili password");
            }

            var hash = GenerateHash(entity.PasswordSalt, password);

            if(hash != entity.PasswordHash)
            {
                throw new Exception("Pogresan username ili password");
            }

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public async Task<Model.Korisnik> Registracija([FromBody]KorisnikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);
            var korisnici = await ctx.Korisniks.ToListAsync();

            foreach (var item in korisnici)
            {
                if (item.KorisnickoIme.Equals(request.KorisnickoIme))
                {
                    throw new UserException("Korisnicko ime vec postoji");
                }

                if (item.Email.Equals(request.Email))
                {
                    throw new UserException("Email vec postoji");
                }
            }

            ctx.Add(entity);

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            entity.Password = null;
            entity.Slika = null;

            ctx.SaveChanges();

            var rola = await ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Korisnik")).FirstOrDefaultAsync();

            Database.KorisnikRola korisnikRola = new KorisnikRola();
            korisnikRola.KorisnikId = entity.Id;
            korisnikRola.RolaId = rola.RolaId;

            ctx.KorisnikRolas.Add(korisnikRola);
            ctx.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }
    }
}
