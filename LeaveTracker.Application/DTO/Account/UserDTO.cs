namespace LeaveTracker.Application.DTO.Account;

public class UserDTO
{
    public required string Id { get; set; }
    public required string EmailAddress { get; set; }
    public required string DisplayName { get; set; }
    public string? ImageURL { get; set; }
    public required string Token { get; set; }
}
