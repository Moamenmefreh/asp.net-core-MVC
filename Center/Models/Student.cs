
namespace Center.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public IEnumerable<Matrial>? Matrials { get; set; }
    }
}
