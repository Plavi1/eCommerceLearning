using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stripovi.Web.Areas.Identity.Data;
using Stripovi.Web.MockData;
using Stripovi.Web.MockData.MockPorudzbinaRepository;

namespace Stripovi.Web.Pages.Administrator.Porudzbine
{
    public class DetailsModel : PageModel
    {
        private readonly UserDbContext _context;
        private readonly IPorudzbinaRepository porudzbinaRepository;

        public DetailsModel(UserDbContext context, 
                            IPorudzbinaRepository porudzbinaRepository)
        {
            _context = context;
            this.porudzbinaRepository = porudzbinaRepository;
        }

        public Porudzbina Porudzbina { get; set; }
        public IEnumerable<Strip> Stripovi { get; set; }

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

            Stripovi = await porudzbinaRepository.GetSveStripoveuPorudzbini(id.Value);

            return Page();
        }
    }
}
