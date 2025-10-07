using Microsoft.EntityFrameworkCore;
using StudentsService.Models;


namespace StudentsService.Infrastructure.Database
{
    public class StudentRepository(AppDbContext context)
    {
        private readonly AppDbContext _context = context;

        public Student AddStudent(StudentDTO dto)
        {
            var student = new Student {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Grade = dto.Grade
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            return student;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student? GetStudentById(Guid id)
        {
            return _context.Students.Find(id);
        }
    }
}
