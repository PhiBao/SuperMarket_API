using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearningMVC.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}