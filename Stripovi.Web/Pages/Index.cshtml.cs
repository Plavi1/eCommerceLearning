using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Stripovi.Web.MockData;
using Stripovi.Web.MockData.MockKorpaRepository;
using Stripovi.Web.MockData.MockStripRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Stripovi.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IStripRepository stripRepository;
        private readonly IKorpaRepository korpaRepository;
        private readonly IMapper mapper;

        public IndexModel(ILogger<IndexModel> logger,
                          SignInManager<IdentityUser> signInManager,
                          IStripRepository stripRepository,
                          IKorpaRepository korpaRepository,
                          IMapper mapper)
        {
            _logger = logger;
            this.signInManager = signInManager;
            this.stripRepository = stripRepository;
            this.korpaRepository = korpaRepository;
            this.mapper = mapper;
        }
       
        public IEnumerable<Strip> Stripovi { get; set; }

        [BindProperty]
        public int IdStripaZaKorpu { get; set; }

        public async Task OnGetAsync()
        {  
            if (signInManager.IsSignedIn(User))
            {
                var ulogvanUser = signInManager.UserManager.GetUserId(User);

                Stripovi = await stripRepository.UserStripoviVanKorpe(ulogvanUser);
                
            }
            else
            {
             Stripovi = await stripRepository.GetStripove();
            }
           
            //  Stripovi = await stripoviService.GetStripove();  //1
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (signInManager.IsSignedIn(User))
            {
                string ulogvanUser = signInManager.UserManager.GetUserId(User);

                var strip = await stripRepository.GetStrip(IdStripaZaKorpu);
                if(strip != null)
                {

                    Korpa novaKorpa = new Korpa();
                    novaKorpa = mapper.Map(strip, novaKorpa);
                    novaKorpa.UserId = ulogvanUser;
                       
                    
                    await korpaRepository.AddKorpa(novaKorpa);
                    return RedirectToAction("OnGetAsync");
                }

            }
            
            TempData["message"] = "Mora te se ulogovati pre nego sto izvrsite porudzbinu!";
            return Redirect("/Identity/Account/Login");
            
          
        }
    }
}
