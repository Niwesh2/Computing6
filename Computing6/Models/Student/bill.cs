using System.ComponentModel.DataAnnotations;

namespace Computing6.Models.Student
{
    public class bill
    {
        [Key] 
        public int billId { get; set; }
        public DateOnly Date { get; set; }
        public double Amount { get; set; }
        public int StudentId { get; set; }
        public int Student { get; set; }


}
}
