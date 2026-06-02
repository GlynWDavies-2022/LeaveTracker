namespace LeaveTracker.Domain.Entities;

public class Office : BaseEntity
{
    public required string Name { get; set; }
    public int CompanyId { get; set; }
    public Company? Company { get; set; }
    public ICollection<Team> Teams { get; set; } = [];
}
