namespace LeaveTracker.Domain.Entities;

public class LeaveRequest : BaseEntity
{
    public int LeaveTypeId { get; set; }

    public LeaveType? LeaveType { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime EndDate { get; set; }

    public int LeaveRequestDecisionId { get; set; }

    public LeaveRequestDecision? LeaveRequestDecision { get; set; }

    public int LeaveRequestDecisionReasonId { get; set; }

    public LeaveRequestDecisionReason? LeaveRequestDecisionReason { get; set; }

    public int RequestorId { get; set; }

    public EmployeeApprover? Requestor { get; set; }

    public int ApproverId { get; set; }

    public EmployeeApprover? Approver { get; set; }
}
