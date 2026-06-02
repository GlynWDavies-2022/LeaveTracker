namespace LeaveTracker.Domain.Entities;

public class Company : BaseEntity
{
    public required string Name { get; set; }
    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public ICollection<Office> Offices { get; set; } = [];
}
