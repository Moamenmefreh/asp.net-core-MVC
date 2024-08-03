using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Center.Models
{
    public class Matrial
    {
        [Key]
        public string Code { get; set; }
        [MaxLength(100)]
        public string? SunbjectName { get; set; }
        public int Level { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public int TeacherId { get; set; }

        public IEnumerable<Teacher>? Teacher { get; set; }
        public IEnumerable<Student>? Students { get; set; }
    }
}
