using System.ComponentModel.DataAnnotations;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Domain.Enums;

namespace practice.Requests.Test;

public class UpdateTestRequest
{
    public string? Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public bool IsRepeatable { get; set; }
    [Required]
    public TestType Type { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime PublishedAt { get; set; }
    [Required]
    public DateTime Deadline { get; set; }
    [Required]
    public int DurationMinutes { get; set; }
    [Required]
    public bool IsPublic { get; set; }
    [Required]
    public int PassingScore { get; set; }
    [Required]
    public int MaxAttempts { get; set; }

    public List<int>? Students { get; set; }
    public List<int>? Projects { get; set; }
    public List<int>? Courses { get; set; }
    public List<int>? Groups { get; set; }
    public List<int>? Directions { get; set; }
}

public class CreateTestRequest
{
    public string? Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public bool IsRepeatable { get; set; }
    [Required]
    public TestType Type { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime PublishedAt { get; set; }
    [Required]
    public DateTime Deadline { get; set; }
    [Required]
    public int DurationMinutes { get; set; }
    [Required]
    public bool IsPublic { get; set; }
    [Required]
    public int PassingScore { get; set; }
    [Required]
    public int MaxAttempts { get; set; }

    public List<int>? Students { get; set; }
    public List<int>? Projects { get; set; }
    public List<int>? Courses { get; set; }
    public List<int>? Groups { get; set; }
    public List<int>? Directions { get; set; }
}
