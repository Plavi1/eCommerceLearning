using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData
{
    public class Kontakt
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Ime i Prezime")]
        public string ImePrezime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Razlog { get; set; }
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string Komentar { get; set; }
    }
}
