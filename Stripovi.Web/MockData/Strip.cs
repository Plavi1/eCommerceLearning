using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData
{
    public class Strip
    {
        [Key]
        public int IdStripa { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Izdavac { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public DateTime VremePosta { get; set; }
        [Required]
        public string Stanje { get; set; }
        [Required]
        public string Jezik { get; set; }
        [Required]
        public string GodinaIzdanja { get; set; }
        [Required]
        public int Cena { get; set; }
        public string imgRoute { get; set; }
    }
}
