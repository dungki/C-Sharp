using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using T1907ACsharp.Adapters;
using T1907ACsharp.Models;

namespace T1907ACsharp.Services
{
    class ProductServices
    {
        private Adapter _adapter = new Adapter();
        public async Task<ProductList> TodaySpecial()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(_adapter.TodaySpecial);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ProductList>(stringContent);
            }
            return null;
        }
    }
}
