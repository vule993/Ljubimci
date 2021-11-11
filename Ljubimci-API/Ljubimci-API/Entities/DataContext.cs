using Ljubimci_API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
namespace Ljubimci_API.Repositories
{
    public class DataContext : IdentityDbContext<
        AppUser, 
        AppRole, 
        int,
        IdentityUserClaim<int>, 
        AppUserRole, 
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>,
        IdentityUserToken<int>
        >
    {
        public DataContext(DbContextOptions options): base(options)
        {
                
        }

        public override DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //relacije izmedju appUser, appUserRole i appRole
            builder.Entity<AppUser>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u=>u.User)
                .HasForeignKey(u=>u.UserId)
                .IsRequired();

            builder.Entity<AppRole>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId)
                .IsRequired();
        }
    }
}
