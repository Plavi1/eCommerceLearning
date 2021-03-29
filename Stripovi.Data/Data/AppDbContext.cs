using Microsoft.EntityFrameworkCore;
using Stripovi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

 namespace Stripovi.Data.Data
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options)
               : base(options)
            {

            }
            public DbSet<Strip> Strip { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
        }
    }

