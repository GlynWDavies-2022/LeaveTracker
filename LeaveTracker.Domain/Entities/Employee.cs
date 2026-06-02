namespace LeaveTracker.Domain.Entities;

public class Employee : BaseEntity
{
    public int TitleId { get; set; }

    public Title? Title { get; set; }

    public Gender? Gender { get; set; }

    public int GenderId { get; set; }

    public required string FirstName { get; set; }

    public string? MiddleName { get; set; }

    public required string LastName { get; set; }

    public required DateOnly DateOfBirth { get; set; }

    public required int JobTitleId { get; set; }

    public JobTitle? JobTitle { get; set; }

    public required string EmailAddress { get; set; }

    public int TeamId { get; set; }

    public Team? Team { get; set; }

    public required string PhoneNumber { get; set; }

    public int PermissionId { get; set; }

    public Permission? Permission { get; set; }

    public required DateOnly EmploymentStartDate { get; set; }

    public DateOnly? EmploymentEndDate { get; set; }

    public ICollection<EmployeeApprover> Requestors { get; set; } = [];

    public ICollection<EmployeeApprover> Approvers { get; set; } = [];

    public int? WorkPatternId { get; set; }

    public WorkPattern? WorkPattern { get; set; }
}
