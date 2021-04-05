using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData.MockKontaktRepository
{
    public interface IKontaktRepository
    {
        Task<Kontakt> AddKontakt(Kontakt kontakt);
        int brojPoruka();
    }
}
