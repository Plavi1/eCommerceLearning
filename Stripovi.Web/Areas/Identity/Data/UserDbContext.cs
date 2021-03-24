using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stripovi.Web.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.Areas.Identity.Data
{
    public class UserDbContext : IdentityDbContext<IdentityUser>
    {
       
            public UserDbContext(DbContextOptions<UserDbContext> options)
                : base(options)
            {
            }
            public DbSet<Strip> Strip { get; set; }
            public DbSet<Korpa> Korpa { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                builder.SeedSuperAdmin();
                builder.MockStripovi();
            }
   
    }
}
