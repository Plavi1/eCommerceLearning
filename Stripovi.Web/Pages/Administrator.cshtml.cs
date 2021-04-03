using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripovi.Web.MockData.MockPorudzbinaRepository;
using Stripovi.Web.MockData.MockStripRepository;

namespace Stripovi.Web.Pages
{
    [Authorize(Roles = "SuperAdmin")]
    public class AdministratorModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IStripRepository stripRepository;
        private readonly IPorudzbinaRepository porudzbinaRepository;

        public AdministratorModel(UserManager<IdentityUser> userManager,
                          IStripRepository stripRepository,
                          IPorudzbinaRepository porudzbinaRepository)
        {
            this.userManager = userManager;
            this.stripRepository = stripRepository;
            this.porudzbinaRepository = porudzbinaRepository;
        }
        public int brojRegistrovanihClanova { get; set; }
        public int brojPorudzbina { get; set; }
        public int brojStripova { get; set; }
        public void OnGet()
        {
            brojRegistrovanihClanova = userManager.Users.Count();
            brojPorudzbina = porudzbinaRepository.GetPorudzbine().Result.Count();
            brojStripova = stripRepository.GetStripove().Result.Count();
        }
    }
}
