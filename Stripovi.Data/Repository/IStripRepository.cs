using Stripovi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stripovi.Data.Repository
{
    public interface IStripRepository
    {
        Task<IEnumerable<Strip>> Search(string naziv);
        Task<IEnumerable<Strip>> GetStripovi();
        Task<Strip> GetStrip(int stripId);
        Task<Strip> AddStrip(Strip strip);
        Task<Strip> UpdateStrip(Strip stripPromena);
        Task<Strip> DeleteStrip(int stripId);
    }
}
