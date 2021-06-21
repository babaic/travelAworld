using eRent.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Data;

namespace travelAworld.EF
{
    public class MyContext : IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public MyContext(DbContextOptions<MyContext> x) : base(x)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });


           
        }


        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<KategorijaNekretnina> KategorijaNekretnina { get; set; }
        public DbSet<Nekretnina> Nekretnina { get; set; }
        public DbSet<Notifikacija> Notifikacija { get; set; }
        public DbSet<Novost> Novost { get; set; }
        public DbSet<Ocjena> Ocjena { get; set; }
        public DbSet<Pretplata> Pretplata { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<Ugovor> Ugovor { get; set; }
        public DbSet<NekretninaSlike> NekretninaSlike { get; set; }
    }
}
