using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Stripovi.Data.Models;
using Stripovi.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Stripovi.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IStripService stripService;

        public IndexModel(ILogger<IndexModel> logger,
                          IStripService stripService)
        {
            _logger = logger;
            this.stripService = stripService;
        }

        public IEnumerable<Strip> Stripovi { get; set; }
        public string errorString { get; set; }


        public void OnGet()
        {
            var sviStipovi = stripService.GetStripove();
            if(sviStipovi != null)
            {
                Stripovi = sviStipovi;
            }
            else
            {
                errorString = "There was an error getting stripovi";
            }
           
            

        }
    }
}
