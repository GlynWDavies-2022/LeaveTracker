namespace LeaveTracker.Domain.Entities;

public class Permission : BaseEntity
{
    public required string Name { get; set; }
    public ICollection<Employee> Employees { get; set; } = [];
}
