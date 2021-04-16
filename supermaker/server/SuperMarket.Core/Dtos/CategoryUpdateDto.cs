using System.ComponentModel.DataAnnotations;

namespace Supermarket.Core.Models
{
    public class CategoryUpdateDto
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

    }
}