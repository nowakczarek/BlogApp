using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Web.Models
{
    public class WebPostChangesHistory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Contents { get; set; }
        [Required]
        public DateTime DateTimeOfPost { get; set; }
        [ForeignKey("WebPost")]
        public int WebPostId { get; set; }
        [Required]
        public WebPost WebPost { get; set; }

    }
}
