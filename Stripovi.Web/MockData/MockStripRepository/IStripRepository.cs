using Stripovi.Web.MockData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData.MockStripRepository
{
    public interface IStripRepository
    {
        Task<IEnumerable<Strip>> GetStripove();
        Task<Strip> GetStrip(int stripId);
        Task<IEnumerable<Strip>> UserStripoviVanKorpe(string userId);
        Task<Strip> AddStrip(Strip strip);
        Task<Strip> UpdateStrip(Strip stripPromena);
        Task<Strip> DeleteStrip(int stripId);
    }
}
