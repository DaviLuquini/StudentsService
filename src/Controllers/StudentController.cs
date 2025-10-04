using Microsoft.AspNetCore.Mvc;
using StudentsService.Infrastructure.Database;

namespace StudentsService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController(StudentRepository repository) : ControllerBase
{
    private readonly StudentRepository _repository = repository;

    [HttpGet(Name = "students")]
    public ActionResult<Student> Get()
    {
        return Ok(_repository.GetAll());
    }
}
