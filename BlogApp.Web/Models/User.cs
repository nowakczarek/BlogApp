using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Web.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public List<WebPost> WebPosts { get; set; } = new List<WebPost>();
    }
}
