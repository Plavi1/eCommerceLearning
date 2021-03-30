using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stripovi.Web.Areas.Identity.Data;
using Stripovi.Web.MockData;

namespace Stripovi.Web.Pages.Administrator.Stripovi
{
    [Authorize(Roles = "SuperAdmin")]
    public class IndexModel : PageModel
    {
        private readonly UserDbContext _context;

        public IndexModel(UserDbContext context)
        {
            _context = context;
        }

        public IList<Strip> Strip { get;set; }

        public async Task OnGetAsync()
        {
            Strip = await _context.Strip.ToListAsync();
        }
    }
}
