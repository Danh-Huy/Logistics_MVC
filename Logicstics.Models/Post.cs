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
        public string? Title { get; set; }

        [DisplayName("Content")]
        public string? Content { get; set; }

        [DisplayName("Author")]
        public string? Author { get; set; }

        public List<PostImage> PostImages { get; set; }
    }
}
