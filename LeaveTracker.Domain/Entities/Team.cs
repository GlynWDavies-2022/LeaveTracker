namespace LeaveTracker.Domain.Entities;

public class Team : BaseEntity
{
    public required string Name { get; set; }
    public int OfficeId { get; set; }
    public Office? Office { get; set; }
    public ICollection<Employee> Employees { get; set; } = [];
}
