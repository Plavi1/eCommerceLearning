using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Stripovi.Web.Areas.Identity.Data;
using Stripovi.Web.MockData;

namespace Stripovi.Web.Pages.Administrator.Stripovi
{
    public class CreateModel : PageModel
    {
        private readonly UserDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CreateModel(UserDbContext context,
                           IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult OnGet()
        {
            Strip = new Strip();
            return Page();
        }

        public Strip Strip { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }

        public async Task<IActionResult> OnPostAsync(Strip strip)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Photo != null)
            {
                if (strip.imgRoute != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath,
                        "images", strip.imgRoute);
                    System.IO.File.Delete(filePath);
                }
                Strip.imgRoute = ProcessUploadedFile();
                _context.Strip.Add(strip);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
        private string ProcessUploadedFile()      //Svaki uploadovan fajl ce biti razlicito sacuvan
        {
            string uniqueFileName = null;

            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}

