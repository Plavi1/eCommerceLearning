using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripovi.Web.MockData;
using Stripovi.Web.MockData.MockPorudzbinaRepository;

namespace Stripovi.Web.Pages
{
    public class StatusPorudzbineModel : PageModel
    {
        private readonly IPorudzbinaRepository porudzbinaRepository;
        private readonly SignInManager<IdentityUser> signInManager;

        public StatusPorudzbineModel(IPorudzbinaRepository porudzbinaRepository,
                                      SignInManager<IdentityUser> signInManager)
        {
            this.porudzbinaRepository = porudzbinaRepository;
            this.signInManager = signInManager;
        }
        public IEnumerable<Porudzbina> Porudzbine { get; set; }
        public async Task OnGet()
        {
            string userId = signInManager.UserManager.GetUserId(User);
            var SvePorudzbine = await porudzbinaRepository.GetPorudzbine();

            Porudzbine = SvePorudzbine.Where(e => e.UserId == userId);
        }
    }
}
