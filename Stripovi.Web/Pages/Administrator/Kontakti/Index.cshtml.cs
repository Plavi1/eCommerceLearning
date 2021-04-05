using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stripovi.Web.Areas.Identity.Data;
using Stripovi.Web.MockData;

namespace Stripovi.Web.Pages.Administrator.Kontakti
{
    [Authorize(Roles = "SuperAdmin")]
    public class IndexModel : PageModel
    {
        private readonly UserDbContext _context;

        public IndexModel(UserDbContext context)
        {
            _context = context;
        }

        public IList<Kontakt> Kontakt { get;set; }

        public async Task OnGetAsync()
        {
            Kontakt = await _context.Kontakt.ToListAsync();
        }
    }
}
