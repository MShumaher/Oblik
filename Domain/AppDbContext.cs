using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Oblik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "5CB180AC-1325-444F-8177-D9A517162427",//insrt new guid
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "52D5A142-F7A2-428E-A603-3AFDC8C79206",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "5CB180AC-1325-444F-8177-D9A517162427",
                UserId = "52D5A142-F7A2-428E-A603-3AFDC8C79206"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("EF86A70C-BE92-4255-BDA3-EE43B6FB401D"),
                CodeWord = "PageIndex",
                Title = "Головна"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("419AD9BA-4570-4325-80D6-EDFD965ACE14"),
                CodeWord = "PageServices",
                Title = "Послуги"
            });                     
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("1E82FB54-C4F1-49D1-A229-3DDF578B8DDC"),
                CodeWord = "PageContacts",
                Title = "Контакти"
            });
        }
    }
}
