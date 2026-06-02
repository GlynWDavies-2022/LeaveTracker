namespace LeaveTracker.Domain.Entities;

public class Country : BaseEntity
{
    public required string ISOCode { get; set; }
    public required string Name { get; set; }
    public required string TimeZone { get; set; }
    public required string Locale { get; set; }
    public required string DateFormat { get; set; }
    public required string TimeFormat { get; set; }
    public required int LanguageId { get; set; }
    public Language? Language { get; set; }
    public required int CurrencyId { get; set; }
    public Currency? Currency { get; set; }
    public ICollection<Company> Companies { get; set; } = [];
}
