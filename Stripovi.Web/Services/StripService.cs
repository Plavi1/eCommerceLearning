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
        public IEnumerable<Strip> GetStripove()
        {
            var responseTask = httpClient.GetAsync("strip");
            responseTask.Wait();

            var result = responseTask.Result;

            IEnumerable<Strip> stripovi;

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadFromJsonAsync<IList<Strip>>();
                readTask.Wait();
                stripovi = readTask.Result;
            }
            else
            {

                stripovi = Enumerable.Empty<Strip>();
            }

            return stripovi;
        }
    }
}
