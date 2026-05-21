namespace LeaveTracker.Domain.Entities;

public class LeaveRequest : BaseEntity
{
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required bool StartInclusive { get; set; }
    public required bool EndInclusive { get; set; }
}
