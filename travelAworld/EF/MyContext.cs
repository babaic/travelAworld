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
        public DbSet<Lokacija> Lokacija { get; set; }
        public DbSet<Ponuda> Ponuda { get; set; }
        public DbSet<VodicPonuda> VodicPonuda { get; set; }
        public DbSet<PonudaSlike> PonudaSlike { get; set; }
        public DbSet<PonudaUser> PonudaUser { get; set; }
        public DbSet<Obavijesti> Obavijesti { get; set; }
        public DbSet<UserSearch> UserSearch { get; set; }
        public DbSet<OtkazanaPonudaUser> OtkazanaPonudaUser { get; set; }
    }
}
