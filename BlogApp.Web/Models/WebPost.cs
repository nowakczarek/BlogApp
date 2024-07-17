using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Web.Models
{
    public class WebPost
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Contents { get; set; }
        [Required]
        public DateTime DateTimeOfPost { get; set; } = DateTime.Now;

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        [Required]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
