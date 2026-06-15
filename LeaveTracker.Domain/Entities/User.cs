namespace LeaveTracker.Domain.Entities;

public class User : BaseEntity
{
    public required string DisplayName { get; set; }
    public required string EmailAddress { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}
