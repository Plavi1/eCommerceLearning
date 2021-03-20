using Stripovi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.Services
{
    public interface IStripService
    {
        IEnumerable<Strip> GetStripove();
    }
}
