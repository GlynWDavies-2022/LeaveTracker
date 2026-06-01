namespace LeaveTracker.Domain.Entities;

public class BankHoliday : BaseEntity
{
    public required string Name { get; set; }
    public required int Year { get; set; }
    public required int Month { get; set; }
    public required int Day { get; set; }
}
