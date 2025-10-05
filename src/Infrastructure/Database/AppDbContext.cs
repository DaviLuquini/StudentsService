using Microsoft.EntityFrameworkCore;
using StudentsService.Models;

namespace StudentsService.Infrastructure.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
    }
}

