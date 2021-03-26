using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData.MockKorpaRepository
{
    public interface IKorpaRepository
    {
        Task<IEnumerable<Korpa>> GetKorpe();
        Task<IEnumerable<Korpa>> UserStripoviuKorpi(string userId);
        Task<Korpa> GetKorpa(int korpaId);
        Task<Korpa> AddKorpa(Korpa korpa);
        Task<Korpa> UpdateKorpa(Korpa korpaPromena);
        Task<Korpa> DeleteStripUKorpi(int stripid);
        Task<Korpa> DeleteSveUKorpi(string userId);
        int UserBrojStripovaUkorpi(string userId);
    }
}
