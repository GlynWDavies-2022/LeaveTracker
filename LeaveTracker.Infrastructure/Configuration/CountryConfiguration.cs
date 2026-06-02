using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Configuration;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Country> builder)
    {
        builder.Property(country => country.ISOCode).HasColumnType("CHAR(3)").IsRequired();
        builder.Property(country => country.Name).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(country => country.TimeZone).HasColumnType("VARCHAR(6)").IsRequired();
        builder.Property(country => country.Locale).HasColumnType("CHAR(5)").IsRequired();
        builder.Property(country => country.DateFormat).HasColumnType("VARCHAR(10)").IsRequired();
        builder.Property(country => country.TimeFormat).HasColumnType("CHAR(5)").IsRequired();
        builder.Property(country => country.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(country => country.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(country => country.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(country => country.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(country => country.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Country
            {
                Id = 1,
                ISOCode = "GBR",
                Name = "United Kingdom",
                TimeZone = "UTC+1",
                Locale = "en-GB",
                DateFormat = "yyyy-MM-dd",
                TimeFormat = "hh:mm",
                LanguageId = 1,
                CurrencyId = 1
            }
        );
    }
}
