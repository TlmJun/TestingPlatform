using System.ComponentModel.DataAnnotations;
using TestingPlatform.Domain.Enums;

namespace practice.Requests.User;

public class UpdateUserRequest
{
    public int Id { get; set; }
    [Required]
    public string? Login { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? MiddleName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public UserRole Role { get; set; }
}
public class CreateUserRequest
{
    public int Id { get; set; }
    [Required]
    public string? Login { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? MiddleName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public UserRole Role { get; set; }
}
