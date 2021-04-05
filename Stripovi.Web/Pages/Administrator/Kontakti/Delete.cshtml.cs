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
    public class DeleteModel : PageModel
    {
        private readonly UserDbContext _context;

        public DeleteModel(UserDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kontakt Kontakt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kontakt = await _context.Kontakt.FirstOrDefaultAsync(m => m.Id == id);

            if (Kontakt == null)
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

            Kontakt = await _context.Kontakt.FindAsync(id);

            if (Kontakt != null)
            {
                _context.Kontakt.Remove(Kontakt);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
