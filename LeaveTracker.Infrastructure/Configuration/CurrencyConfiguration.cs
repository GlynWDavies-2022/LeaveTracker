using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder
            .HasMany(currency => currency.Countries)
            .WithOne(country => country.Currency)
            .HasForeignKey(country => country.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(currency => currency.ISOCode).HasColumnType("CHAR(3)").IsRequired();
        builder.Property(currency => currency.Name).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(currency => currency.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(currency => currency.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(currency => currency.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(currency => currency.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(currency => currency.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Currency
            {
                Id = 1,
                ISOCode = "GBP",
                Name = "British Pound Sterling"
            }
        );
    }
}
