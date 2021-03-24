using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripovi.Web.MockData;
using Stripovi.Web.MockData.MockKorpaRepository;
using Stripovi.Web.MockData.MockStripRepository;

namespace Stripovi.Web.Pages
{
    [Authorize]
    public class KorpaModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IStripRepository stripRepository;
        private readonly IKorpaRepository korpaRepository;
        private readonly IMapper mapper;

        public KorpaModel(SignInManager<IdentityUser> signInManager,
                          IStripRepository stripRepository,
                          IKorpaRepository korpaRepository,
                          IMapper mapper)
        {
            this.signInManager = signInManager;
            this.stripRepository = stripRepository;
            this.korpaRepository = korpaRepository;
            this.mapper = mapper;
        }

        [BindProperty]
        public int IdStripaObrisi { get; set; }

        public IEnumerable<Korpa> StripoviuKorpi { get; set; }

        public async Task OnGet()
        {
            var ulogvanUser = signInManager.UserManager.GetUserId(User);

            StripoviuKorpi = await korpaRepository.UserStripoviuKorpi(ulogvanUser);
        }

        public async Task<IActionResult> OnPost()
        {
            var selektovanStripuKorpi = await korpaRepository.GetKorpa(IdStripaObrisi);
            
            if(selektovanStripuKorpi != null)
            {
                Strip vracenStrip = new Strip();
                vracenStrip = mapper.Map(selektovanStripuKorpi, vracenStrip);

                var result2 = await korpaRepository.DeleteKorpa(selektovanStripuKorpi.Id);

                if (result2 == null)
                {
                    return NotFound();
                }
                TempData["message"] = "Strip je obrisan iz korpe!";
                return RedirectToAction("OnGetAsync");
            }
            return RedirectToAction("OnGetAsync");
        }
    }
}
