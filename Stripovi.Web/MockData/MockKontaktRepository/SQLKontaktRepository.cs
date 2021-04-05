using Stripovi.Web.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData.MockKontaktRepository
{
    public class SQLKontaktRepository : IKontaktRepository
    {
        private readonly UserDbContext context;

        public SQLKontaktRepository(UserDbContext context)
        {
            this.context = context;
        }
        public async Task<Kontakt> AddKontakt(Kontakt kontakt)
        {
            var result = await context.Kontakt.AddAsync(kontakt);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public int brojPoruka()
        {
            return context.Kontakt.Count();
        }
    }
}
