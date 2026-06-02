namespace LeaveTracker.Domain.Entities;

public class LeaveRequestDecision : BaseEntity
{
    public required string Description { get; set; }
    public ICollection<LeaveRequest> LeaveRequests { get; set; } = [];
}
