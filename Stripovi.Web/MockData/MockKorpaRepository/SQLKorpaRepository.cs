using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stripovi.Web.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData.MockKorpaRepository
{
    public class SQLKorpaRepository : IKorpaRepository
    {
        private readonly UserDbContext context;

        public SQLKorpaRepository(UserDbContext context)
        {
            this.context = context;

        }
        public async Task<Korpa> AddKorpa(Korpa korpa)
        {
            var result = await context.Korpa.AddAsync(korpa);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Korpa> DeleteKorpa(int korpaId)
        {
            var result = await context.Korpa
               .FirstOrDefaultAsync(e => e.Id == korpaId);
            if (result != null)
            {
                context.Korpa.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Korpa> GetKorpa(int korpaId)
        {
            return await context.Korpa
           .FirstOrDefaultAsync(e => e.Id == korpaId);
        }

        public async Task<IEnumerable<Korpa>> GetKorpe()
        {
            return await context.Korpa.ToListAsync();
        }

        public async Task<Korpa> UpdateKorpa(Korpa korpaPromena)
        {
            var result = await context.Korpa
                .FirstOrDefaultAsync(e => e.Id == korpaPromena.IdStripa);

            if (result != null)
            {
                result.IdStripa = korpaPromena.IdStripa;
                result.UserId = korpaPromena.UserId;

                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public int UserBrojStripovaUkorpi(string userId)
        {
            int broj = context.Korpa.ToList().Where(e => e.UserId == userId).Count();
            return broj;
        }

        public async Task<IEnumerable<Korpa>> UserStripoviuKorpi(string userId)
        {
            var stripoviUKorpi = await context.Korpa.ToListAsync();

            return stripoviUKorpi.Where(e => e.UserId == userId);
        }
    }
}
