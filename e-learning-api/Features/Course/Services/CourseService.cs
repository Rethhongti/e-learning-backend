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

    public async Task<CourseEntity> Create(CreateCourseDto payload)
    {
        var course = new CourseEntity()
        {
            Title = payload.Title,
            Price = payload.Price,
            Description = payload.Description,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
        };
        await dbContext.Courses.AddAsync(course);
        await dbContext.SaveChangesAsync();

        return course;
    }
}