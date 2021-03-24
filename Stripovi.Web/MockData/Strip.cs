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
        public string Naziv { get; set; }
        public string Izdavac { get; set; }
        public string Autor { get; set; }
        public DateTime VremePosta { get; set; }
        public string Stanje { get; set; }
        public string Jezik { get; set; }
        public string GodinaIzdanja { get; set; }
        public int Cena { get; set; }
        public string imgRoute { get; set; }
    }
}
