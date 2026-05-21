namespace LeaveTracker.Domain.Entities;

public class Employee : BaseEntity
{
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
    public required string DateOfBirth { get; set; }
    public required string EmailAddress { get; set; }
    public required string PhoneNumber { get; set; }
    public required DateOnly StartDate { get; set; }
    public required DateOnly ProbationDate { get; set; }
    public DateOnly? EndDate { get; set; }
}
