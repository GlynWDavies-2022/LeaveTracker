namespace LeaveTracker.Domain.Entities;

public class WorkPattern : BaseEntity
{
    public required string Name { get; set; }
    public ICollection<WorkDay> WorkDays { get; set; } = [];
    public ICollection<Employee> Employees { get; set; } = [];
}
