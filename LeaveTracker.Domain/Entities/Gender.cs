namespace LeaveTracker.Domain.Entities;

public class Gender : BaseEntity
{
    public required string Description { get; set; }
    public ICollection<Employee> Employees { get; set; } = [];
}
