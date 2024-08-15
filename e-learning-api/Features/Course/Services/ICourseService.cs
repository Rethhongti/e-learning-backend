using e_learning_api.Features.Course.Model;

namespace e_learning_api.Features.Course;

public interface ICourseService
{
    Task<List<CourseEntity>> GetAll();

    Task<CourseEntity> Create(CreateCourseDto payload);
}