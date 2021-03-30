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

namespace Stripovi.Web.Pages.Administrator.Porudzbine
{
    [Authorize(Roles = "SuperAdmin")]
    public class IndexModel : PageModel
    {
        private readonly UserDbContext _context;

        public IndexModel(UserDbContext context)
        {
            _context = context;
        }

        public IList<Porudzbina> Porudzbina { get;set; }

        public async Task OnGetAsync()
        {
            Porudzbina = await _context.Porudzbina
                .Include(p => p.User).ToListAsync();
        }
    }
}
