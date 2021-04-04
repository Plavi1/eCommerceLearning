using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripovi.Web.MockData;

namespace Stripovi.Web.Pages
{
    public class ContactModel : PageModel
    {
        public Kontakt Kontakt { get; set; }
        public void OnGet()
        {
        }
    }
}
