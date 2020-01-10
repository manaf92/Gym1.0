
using Gym1._0.Core.Models;
using Gym1._0.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gym1._0.Data
{
    public class ApplicationDbContext : IdentityDbContext < ApplicationUser, IdentityRole ,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GymClass> GymClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Always  first 
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUserGymClass>()
                .HasKey(K => new
                {
                    K.ApplicationUserId,
                    K.GymClassId
                }
                );
                
        }
    }
}
