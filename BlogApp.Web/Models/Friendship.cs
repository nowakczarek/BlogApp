using BlogApp.Web.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Web.Models
{
    public class Friendship
    {
        [Key]
        public int Id { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string? FriendId { get; set; }
        public ApplicationUser Friend { get; set; }

        [Required]
        public FriendshipStatus FriendStatus { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
