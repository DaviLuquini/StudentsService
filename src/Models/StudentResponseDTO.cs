namespace StudentsService.Models
{
    public class StudentResponseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Grade { get; set; }
        public char UniqueLetter { get; set; }
    }
}
