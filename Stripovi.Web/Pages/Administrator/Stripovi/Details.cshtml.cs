using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stripovi.Web.Areas.Identity.Data;
using Stripovi.Web.MockData;

namespace Stripovi.Web.Pages.Administrator.Stripovi
{
    public class DetailsModel : PageModel
    {
        private readonly UserDbContext _context;

        public DetailsModel(UserDbContext context)
        {
            _context = context;
        }

        public Strip Strip { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Strip = await _context.Strip.FirstOrDefaultAsync(m => m.IdStripa == id);

            if (Strip == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
