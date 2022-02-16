using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class KorisnikController : BaseCRUDController<Model.Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        protected readonly IKorisnikService Service;
        public KorisnikController(IKorisnikService service) : base(service)
        {
            Service = service;
        }

        [Authorize]
        [HttpGet("login")]
        public virtual Task<Model.Korisnik> Login(string username, string password)
        {
            string authorization = HttpContext.Request.Headers["Authorization"];

            string encodedHeader = authorization["Basic ".Length..].Trim();

            Encoding encoding = Encoding.GetEncoding("iso-8859-1");
            string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedHeader));

            int seperatorIndex = usernamePassword.IndexOf(':');

            return Service.Login(usernamePassword.Substring(0, seperatorIndex), usernamePassword[(seperatorIndex + 1)..]);
        }
        
        [HttpPost("registracija")]
        public virtual Task<Model.Korisnik> Registracija(KorisnikInsertRequest request)
        {
            return Service.Registracija(request);
        }
    }
}
