using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PetShop.Helpers
{
    public static class Extension
    {
        public static string GetUserId(this IHttpContextAccessor httpContext)
        {
            if (httpContext.HttpContext.User == null)
            {
                return string.Empty;
            }
            return httpContext.HttpContext.User.Claims.Single(x => x.Type == ClaimTypes.NameIdentifier).Value;
        }
    }
}