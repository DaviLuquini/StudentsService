using System.ComponentModel.DataAnnotations;

namespace StudentsService.Models
{
    public class StudentDTO
    {
        public required string Name { get; set; }

        [Range(0, 10)]
        public int Grade { get; set; }
    }
}
