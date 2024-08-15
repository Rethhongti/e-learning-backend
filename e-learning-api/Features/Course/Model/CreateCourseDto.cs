namespace e_learning_api.Features.Course.Model;

public class CreateCourseDto
{
    public required string Title { set; get; }
    
    public required double Price { set; get; }
    
    public string? Description { set; get; }
}