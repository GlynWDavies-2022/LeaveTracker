using System.ComponentModel.DataAnnotations;

namespace LeaveTracker.Application.DTO.Account;

public class RegisterDTO
{
    [Required]
    public string DisplayName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    public string Password { get; set; } = string.Empty;
}
