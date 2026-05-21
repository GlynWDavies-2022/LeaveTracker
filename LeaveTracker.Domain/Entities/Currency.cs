namespace LeaveTracker.Domain.Entities;

public class Currency : BaseEntity
{
    public required string ISOCode { get; set; }
    public required string Name { get; set; }
}
