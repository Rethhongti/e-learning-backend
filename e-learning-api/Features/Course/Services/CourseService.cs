using e_learning_api.Database;
using e_learning_api.Features.Course.Model;
using Microsoft.EntityFrameworkCore;

namespace e_learning_api.Features.Course;

public class CourseService: ICourseService
{
    private readonly AppDbContext dbContext;

    public CourseService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Task<List<CourseEntity>> GetAll()
    {
        return dbContext.Courses.ToListAsync();
    }
}