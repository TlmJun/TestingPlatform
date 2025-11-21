using practice.Responses.Course;
using practice.Responses.Direction;
using practice.Responses.Group;
using practice.Responses.Project;
using practice.Responses.Student;
using TestingPlatform.Domain.Enums;
using TestingPlatform.Responses;

namespace practice.Responses.Test;

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
    public List<StudentResponse> Students { get; set; }
    public List<ProjectResponse> Projects { get; set; }
    public List<CourseResponse> Courses { get; set; }
    public List<GroupResponse> Groups { get; set; }
    public List<DirectionResponse> Directions { get; set; }
}