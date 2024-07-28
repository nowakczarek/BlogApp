using BlogApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Web.Data_Access
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<WebPost> WebPosts { get; set; }
        public DbSet<WebPostChangesHistory> WebPostsChangesHistory { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var adminRole = new IdentityRole("admin");
            adminRole.NormalizedName = "admin";

            var clientRole = new IdentityRole("client");
            clientRole.NormalizedName = "client";

            builder.Entity<IdentityRole>().HasData(adminRole, clientRole);

            var admin = new ApplicationUser
            {
                Id = "1",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "User"
            };

            admin.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(admin, "Admin123!");

            var client = new ApplicationUser
            {
                Id = "2",
                UserName = "client@client.com",
                NormalizedUserName = "CLIENT@CLIENT.COM",
                Email = "client@client.com",
                NormalizedEmail = "CLIENT@CLIENT.com",
                EmailConfirmed = true,
                FirstName = "Client",
                LastName = "User"
            };

            client.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(client, "Client123!");

            builder.Entity<ApplicationUser>().HasData(admin, client);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = admin.Id, RoleId = adminRole.Id },
                new IdentityUserRole<string> { UserId = client.Id, RoleId = clientRole.Id }
                );



        }


    }
}
