using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? ProfileImgPath { get; set; }
        public string? ProfileBackgroundImgPath { get; set; }
        public List<WebPost> WebPosts { get; set; } = new List<WebPost>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Friendship> FriendshipInitiated { get; set; } = new List<Friendship>();
        public List<Friendship> FriendshipReceived { get; set; } = new List<Friendship>();
    }
}
