using e_learning_api.Features.Course.Model;
using Microsoft.AspNetCore.Mvc;

namespace e_learning_api.Features.Course;

[ApiController]
[Route("courses")]
public class CourseController: ControllerBase
{
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        this._courseService = courseService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var courses = await _courseService.GetAll();
        return Ok(courses);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCourseDto payload)
    {
        var course = await _courseService.Create(payload);
        return Ok(course);
    }
}