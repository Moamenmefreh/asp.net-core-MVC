using System.ComponentModel.DataAnnotations;

namespace Center.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Specialization { get; set; }
    }
}
