using System.ComponentModel.DataAnnotations.Schema;

namespace e_learning_api.Features.Course.Model;

public class CourseEntity
{
    [Column("id")]
    public int Id { set; get; }

    [Column("title")]
    public required string Title { set; get; }
    
    [Column("price")]
    public required double Price { set; get; }
    
    [Column("description")]
    public string? Description { set; get; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}