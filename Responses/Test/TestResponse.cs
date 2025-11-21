using TestingPlatform.Domain.Enums;

namespace practice.Responses.Test;
public class TestResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsRepeatable { get; set; }
    public TestType Type { get; set; }
    public bool IsPublic { get; set; }
    public DateTime CreatedAt { get; set; }
}