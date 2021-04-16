using System.ComponentModel.DataAnnotations;

namespace Supermarket.Core.Models
{
    public class ProductUpdateDto
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(500)]
        public string ImageUrl { get; set; }
        public float Price { get; set; }
    }
}