using PetShop.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.WinUI
{
    public class APIService
    {
        private string route = null;

        public APIService(string _route)
        {
            route = _route;
        }

        public async Task<T> Get<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{route}";
            if(request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }

            var result = await url.GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{route}/{id}";

            var result = await url.GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{route}";

            var result = await url.PostJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Update<T>(object id,object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{route}/{id}";

            var result = await url.PutJsonAsync(request).ReceiveJson<T>();

            return result;
        }
    }
}
