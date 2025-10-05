using Microsoft.AspNetCore.Mvc;
using StudentsService.Infrastructure.Database;
using StudentsService.Models;

namespace StudentsService.Controllers;
[ApiController]
[Route("students")]
public class StudentsController(StudentRepository repository) : ControllerBase
{
    private readonly StudentRepository _repository = repository;

    [HttpGet]
    public ActionResult<IEnumerable<StudentResponseDTO>> GetStudentList()
    {
        var students = _repository.GetAll();

        var result = students.Select(s => new StudentResponseDTO {
            Id = s.Id,
            Name = s.Name,
            Grade = s.Grade,
            UniqueLetter = GetFirstNonRepeatingLetter(s.Name)
        });

        return Ok(result);
    }

    [HttpGet("{id}")]
    public ActionResult<StudentResponseDTO> GetById(Guid id)
    {
        var student = _repository.GetById(id);
        if (student == null)
            return NotFound("Student not found");

        var result = new StudentResponseDTO {
            Id = student.Id,
            Name = student.Name,
            Grade = student.Grade,
            UniqueLetter = GetFirstNonRepeatingLetter(student.Name)
        };

        return Ok(result);
    }

    [HttpPost]
    public ActionResult<StudentDTO> PostStudent([FromBody] StudentDTO student)
    {
        if (student.Grade < 0 || student.Grade > 10)
            return BadRequest("Grade must be between 0 and 10");

        return Ok(_repository.Add(student));
    }

    static private char GetFirstNonRepeatingLetter(string name)
    {
        var lower = name.ToLower();
        foreach (var c in lower)
        {
            if (lower.Count(x => x == c) == 1)
                return c;
        }
        return '_';
    }
}

