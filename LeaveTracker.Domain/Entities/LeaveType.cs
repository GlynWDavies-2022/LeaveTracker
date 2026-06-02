namespace LeaveTracker.Domain.Entities;

public class LeaveType : BaseEntity
{
    public required string Name { get; set; }
    public ICollection<LeaveRequest> LeaveRequests { get; set; } = [];
}
