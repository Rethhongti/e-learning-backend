using e_learning_api.Features.Course.Model;
using Microsoft.EntityFrameworkCore;

namespace e_learning_api.Database;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<CourseEntity> Courses { get; set; }
}