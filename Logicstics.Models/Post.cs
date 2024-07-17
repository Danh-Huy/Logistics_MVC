using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Logistics.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Title")]
        [Length(1, 20)]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
