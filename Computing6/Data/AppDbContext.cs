using Computing6.Models.Student;
using Microsoft.EntityFrameworkCore;

namespace Computing6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
