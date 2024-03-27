using System.ComponentModel.DataAnnotations;

namespace Computing6.Models.Student
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
