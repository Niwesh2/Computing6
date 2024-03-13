using System.ComponentModel.DataAnnotations;

namespace Computing6.Models.Student
{
    public class Student
    {
        [Key]
        public int LMUID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string FypTitle { get; set; }


    }
}
