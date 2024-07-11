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
        public DateTime DateTimeOfPost { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}
