namespace StudentsService.Models
{
    public class StudentResponseDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Grade { get; set; }
        public char UniqueLetter { get; set; }
    }
}
