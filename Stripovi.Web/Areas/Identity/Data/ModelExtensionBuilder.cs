using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stripovi.Web.MockData;
using System.Collections.Generic;

namespace Stripovi.Web.Areas.Identity.Data
{
    public static class ModelExtensionBuilder
    {
        public static void SeedSuperAdmin(this ModelBuilder modelBuilder)
        {
            string ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";


            // Pravimo Admin Role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "SuperAdmin",
                NormalizedName = "SuperAdmin",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            // Pravimo Korisnika
            var Korisnik = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "Admin@admin.com",
                EmailConfirmed = true,
                UserName = "Admin@admin.com",
                LockoutEnabled = true,
                NormalizedEmail = "ADMIN@ADMIN.COM",
                NormalizedUserName = "ADMIN@ADMIN.COM"
            };

            //Setuj Korisniku PW
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            Korisnik.PasswordHash = ph.HashPassword(Korisnik, "Sifra1");

            //Ubaci Korisnika
            modelBuilder.Entity<IdentityUser>().HasData(Korisnik);


            //Postavi Korisnika za Admina
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
        public static void MockStripovi(this ModelBuilder modelBuilder)
        {
            
            List<Strip> stripList = new List<Strip>(){
                new Strip(){IdStripa = 1 ,Autor = "Ticijano Sklavi", Naziv = "Dilan Dog", GodinaIzdanja = "2006", Jezik = "Srpski", Izdavac = "Veseli Cetvrtak", Cena = 300, Stanje="Novo", imgRoute = "DilanDog.jpg" },
                new Strip(){IdStripa = 2 ,Autor = "Max Bunker ", Naziv = "Alan Ford", GodinaIzdanja = "1995", Jezik = "Srpski", Izdavac = "Vsdada", Cena = 250, Stanje="Novo", imgRoute = "AlanFord.jpg" },
                new Strip(){IdStripa = 3 ,Autor = "EsseGesse", Naziv = "Blek", GodinaIzdanja = "1999", Jezik = "Srpski", Izdavac = "Abcvasld", Cena = 300, Stanje="Polovno", imgRoute = "Blek.jpg" },
                new Strip(){IdStripa = 4 ,Autor = "Serdjo Boneli", Naziv = "Zagor", GodinaIzdanja = "2012", Jezik = "Srpski", Izdavac = "Veseli Cetvrtak", Cena = 100, Stanje="Polovno", imgRoute = "Zagor.jpg" },
            };

            modelBuilder.Entity<Strip>().HasData(stripList);
        }
    }
}
