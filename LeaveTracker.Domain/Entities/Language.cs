namespace LeaveTracker.Domain.Entities;

public class Language : BaseEntity
{
    public required string ISOCode { get; set; }
    public required string Name { get; set; }
    public ICollection<Country> Countries { get; set; } = [];
}
