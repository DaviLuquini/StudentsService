using System.ComponentModel.DataAnnotations;

namespace StudentsService
{
    public class Student
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        [Range(0, 10)]
        public int Grade { get; set; }
    }
}
