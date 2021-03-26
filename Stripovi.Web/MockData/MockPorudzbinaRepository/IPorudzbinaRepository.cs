using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData.MockPorudzbinaRepository
{
    public interface IPorudzbinaRepository
    {
        Task<IEnumerable<Porudzbina>> GetPorudzbine();
        Task<Porudzbina> GetPorudzbinu(int porudzbinaId);
        Task<Porudzbina> AddPorudzbinu(Porudzbina porudzbina, List<int> IdstripovaUPorudzbini);
        Task<Porudzbina> DeletePorudzbinu(int porudzbinaId);
        Task<IEnumerable<Strip>> GetSveStripoveuPorudzbini(int porudzbinaId);
        int UserBrojPorudzbina(string userId);
    }
}
