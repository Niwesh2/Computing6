using System.ComponentModel.DataAnnotations;

namespace Computing6.Models.Student
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string title { get; set; }

        public string Author { get; set; }

        public DateOnly RentedOnly { get; set; }

        public int StudentId { get; set; } //FK

        public Student Student { get; set; } //REference
    }
}
