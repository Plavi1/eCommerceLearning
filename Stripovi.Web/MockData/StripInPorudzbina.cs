using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stripovi.Web.MockData
{
    public class StripInPorudzbina
    {
        [ForeignKey("Porudzbina"), Column(Order = 0)]
        public int IdPorudzbine { get; set; }
        public Porudzbina Porudzbina { get; set; }

        [ForeignKey("Strip"), Column(Order = 1)]
        public int IdStripa { get; set; }
        public Strip Strip { get; set; }
    }
}
