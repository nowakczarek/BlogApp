using BlogApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Web.Data_Access
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<WebPost> WebPosts { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

    }
}
