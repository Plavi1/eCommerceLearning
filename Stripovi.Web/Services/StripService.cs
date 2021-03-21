using Stripovi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Stripovi.Web.Services
{
    public class StripService : IStripService
    {
        private readonly HttpClient httpClient;

        public StripService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public async Task<IEnumerable<Strip>> GetStripove()
        {
            var responseTask = await httpClient.GetAsync("strip");

            IEnumerable<Strip> stripovi;

            if (responseTask.IsSuccessStatusCode)
            {
                stripovi = await responseTask.Content.ReadFromJsonAsync<IList<Strip>>(); 
            }
            else
            {
                stripovi = Enumerable.Empty<Strip>();
            }

            return stripovi;
        }
    }
}
