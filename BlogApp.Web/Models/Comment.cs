using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Web.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Text { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("WebPost")]
        public int WebPostId { get; set; }
        public WebPost WebPost { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
