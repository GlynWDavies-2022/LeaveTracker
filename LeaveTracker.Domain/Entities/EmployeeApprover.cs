namespace LeaveTracker.Domain.Entities;

public class EmployeeApprover : BaseEntity
{
    public Employee? Employee { get; set; }
    public int EmployeeId { get; set; }
    public Employee? Approver { get; set; }
    public int ApproverId { get; set; }
    public ICollection<LeaveRequest> ApprovedLeaveRequests { get; set; } = [];
    public ICollection<LeaveRequest> RequestedLeaveRequests { get; set; } = [];
}
