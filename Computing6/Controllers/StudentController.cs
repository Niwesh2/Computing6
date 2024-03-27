using Computing6.Data;
using Computing6.Models.Student;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Computing6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public StudentController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student request)
        {
            var AddStudent = new Student()

            {
                Name = request.Name,
                Email = request.Email,
                FypTitle = request.FypTitle,
            };
            await dbContext.Students.AddAsync(AddStudent);
            await dbContext.SaveChangesAsync();

            return Ok(AddStudent);
        }
     }
}
