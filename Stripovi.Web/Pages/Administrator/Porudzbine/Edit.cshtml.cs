using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stripovi.Web.Areas.Identity.Data;
using Stripovi.Web.MockData;

namespace Stripovi.Web.Pages.Administrator.Porudzbine
{
    public class EditModel : PageModel
    {
        private readonly UserDbContext _context;

        public EditModel(UserDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Porudzbina Porudzbina { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Porudzbina = await _context.Porudzbina
                .Include(p => p.User).FirstOrDefaultAsync(m => m.IdPorudzbine == id);

            if (Porudzbina == null)
            {
                return NotFound();
            }
           ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Porudzbina).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PorudzbinaExists(Porudzbina.IdPorudzbine))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PorudzbinaExists(int id)
        {
            return _context.Porudzbina.Any(e => e.IdPorudzbine == id);
        }
    }
}
