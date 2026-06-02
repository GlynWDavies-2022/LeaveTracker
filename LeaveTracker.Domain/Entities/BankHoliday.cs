namespace LeaveTracker.Domain.Entities;

public class BankHoliday : BaseEntity
{
    public required string Name { get; set; }
    public required DateOnly Date { get; set; }
}
