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
    public class DeleteModel : PageModel
    {
        private readonly UserDbContext _context;

        public DeleteModel(UserDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Strip = await _context.Strip.FindAsync(id);

            if (Strip != null)
            {
                _context.Strip.Remove(Strip);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
