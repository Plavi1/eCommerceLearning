using Microsoft.EntityFrameworkCore;
using Stripovi.Data.Data;
using Stripovi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripovi.Data.Repository
{
    public class SQLStripRepository : IStripRepository
    {
        private readonly AppDbContext context;

        public SQLStripRepository( AppDbContext context)
        {
            this.context = context;
        }


        public async Task<Strip> AddStrip(Strip strip)
        {
            var result = await context.Strip.AddAsync(strip);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Strip> GetStrip(int stripId)
        {
            return await context.Strip
                 .FirstOrDefaultAsync(e => e.IdStripa == stripId);

        }

        public async Task<IEnumerable<Strip>> GetStripovi()
        {
            return await context.Strip.ToListAsync();
        }

        public async Task<Strip> UpdateStrip(Strip stripPromena)
        {
            var result = await context.Strip
                .FirstOrDefaultAsync(e => e.IdStripa == stripPromena.IdStripa);

            if (result != null)
            {
                result.Naziv = stripPromena.Naziv;
                result.Izdavac = stripPromena.Izdavac;
                result.Autor = stripPromena.Autor;
                result.VremePosta = stripPromena.VremePosta;
                result.Stanje = stripPromena.Stanje;
                result.Jezik = stripPromena.Jezik;
                result.GodinaIzdanja = stripPromena.GodinaIzdanja;
                result.Cena = stripPromena.Cena;

                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<Strip> DeleteStrip(int stripId)
        {
            var result = await context.Strip
                .FirstOrDefaultAsync(e => e.IdStripa == stripId);
            if (result != null)
            {
                context.Strip.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Strip>> Search(string naziv)
        {
            IQueryable<Strip> query = context.Strip;
            if(!string.IsNullOrEmpty(naziv))
            {
                query = query.Where(e => e.Naziv.Contains(naziv));
            }
            return await query.ToListAsync();
        }
    }
}
