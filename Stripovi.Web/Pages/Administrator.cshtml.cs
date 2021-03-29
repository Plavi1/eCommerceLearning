using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Stripovi.Web.Pages
{
    [Authorize(Roles = "SuperAdmin")]
    public class AdministratorModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
