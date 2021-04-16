using System.ComponentModel.DataAnnotations;

namespace LearningMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        public int Age { get; set; }
        [MaxLength(512)]
        public string Address { get; set; }
        // public virtual Class IdNavigation { get; set; }
    }
}