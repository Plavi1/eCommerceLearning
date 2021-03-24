//using Stripovi.Data.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Json;
//using System.Threading.Tasks;

//namespace Stripovi.Web.Services.Stripovi
//{
//    public class StripoviService : IStripoviService
//    {
//        private readonly IHttpClientFactory httpClient;

//        public StripoviService(IHttpClientFactory httpClient)
//        {
//            this.httpClient = httpClient;
//        }
//        public async Task<IEnumerable<Strip>> GetStripove()
//        {
//            var client = httpClient.CreateClient("Stripovi");            //Zasto sporo obradjuje kada se desava error?

//            IEnumerable<Strip> stripovi;
//            try
//            {
//                stripovi = await client.GetFromJsonAsync<IList<Strip>>("strip");
//            }
//            catch (Exception)
//            {
//                 stripovi = Enumerable.Empty<Strip>();
//            }
//            return stripovi;
//        }
//    }
//}
