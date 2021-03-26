using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData
{
    public class Porudzbina
    {
        [Key]
        public int IdPorudzbine { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public string Grad { get; set; }
        public int PostanskiBroj { get; set; }
        public string Ulica { get; set; }
        public string KucniBroj { get; set; }
        public string Placanje { get; set; }
        public string Pitanje { get; set; }
        public int UkupnaCena { get; set; }
        public int BrojPorucenihStripova { get; set; }
    }
}
