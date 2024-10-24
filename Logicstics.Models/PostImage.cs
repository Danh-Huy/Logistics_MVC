using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Models
{
    public class PostImage
    {
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}
