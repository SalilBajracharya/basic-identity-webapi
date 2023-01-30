using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityWebApi.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IPasswordHasher<ApplicationUser> passwordHasher)
            :base(options)
        {
            _passwordHasher = passwordHasher;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string adminId = Guid.NewGuid().ToString();
            string roleId = Guid.NewGuid().ToString();

            // Seeding an Admin
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { 
                    Id = adminId,
                    UserName = "d.admin",
                    NormalizedUserName = "D.ADMIN",
                    Email = "d.admin@example.com",
                    NormalizedEmail = "D.ADMIN@EXAMPLE.COM",
                    PasswordHash = _passwordHasher.HashPassword(null, "Server@123")
                });

            // Seeding AspNetRoles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = roleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                { 
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                });

            // Seeding AspNetUserRoles
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = adminId
                }
                );
            base.OnModelCreating(builder);
        }
    }
}
