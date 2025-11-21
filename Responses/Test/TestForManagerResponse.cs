using practice.Responses.Student;
using Presentation_Layer.Responses.Course;
using Presentation_Layer.Responses.Direction;
using Presentation_Layer.Responses.Group;
using Presentation_Layer.Responses.Project;
using TestingPlatform.Domain.Enums;
using TestingPlatform.Responses;

namespace Presentation_Layer.Responses.Test;

public class TestForManagerResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsRepeatable { get; set; }
    public TestType Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime PublishedAt { get; set; }
    public DateTime Deadline { get; set; }
    public int? DurationMinutes { get; set; }
    public bool IsPublic { get; set; }
    public int? PassingScore { get; set; }
    public int? MaxAttempts { get; set; }
}