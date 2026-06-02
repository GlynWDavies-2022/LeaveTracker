using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class BankHolidayConfiguration : IEntityTypeConfiguration<BankHoliday>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BankHoliday> builder)
    {
        builder.Property(bankHoliday => bankHoliday.Name).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(bankHoliday => bankHoliday.Date).HasColumnType("DATE").IsRequired();
        builder.Property(bankHoliday => bankHoliday.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(bankHoliday => bankHoliday.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(bankHoliday => bankHoliday.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(bankHoliday => bankHoliday.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(bankHoliday => bankHoliday.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new BankHoliday
            {
                Id = 1,
                Name = "New Years Day",
                Date = new DateOnly(2025, 1, 1)
            },
            new BankHoliday
            {
                Id = 2,
                Name = "Good Friday",
                Date = new DateOnly(2025, 4, 18)
            },
            new BankHoliday
            {
                Id = 3,
                Name = "Easter Monday",
                Date = new DateOnly(2025, 4, 21)
            },
            new BankHoliday
            {
                Id = 4,
                Name = "Early May Bank Holiday",
                Date = new DateOnly(2025, 5, 5)
            },
            new BankHoliday
            {
                Id = 5,
                Name = "Spring Bank Holiday",
                Date = new DateOnly(2025, 5, 26)
            },
            new BankHoliday
            {
                Id = 6,
                Name = "Summer Bank Holiday",
                Date = new DateOnly(2025, 8, 25)
            },
            new BankHoliday
            {
                Id = 7,
                Name = "Christmas Day",
                Date = new DateOnly(2025, 12, 25)
            },
            new BankHoliday
            {
                Id = 8,
                Name = "Boxing Day",
                Date = new DateOnly(2025, 12, 26)
            },
            new BankHoliday
            {
                Id = 9,
                Name = "New Years Day",
                Date = new DateOnly(2026, 1, 1)
            },
            new BankHoliday
            {
                Id = 10,
                Name = "Good Friday",
                Date = new DateOnly(2026, 4, 3)
            },
            new BankHoliday
            {
                Id = 11,
                Name = "Easter Monday",
                Date = new DateOnly(2026, 4, 6)
            },
            new BankHoliday
            {
                Id = 12,
                Name = "Early May Bank Holiday",
                Date = new DateOnly(2026, 5, 4)
            },
            new BankHoliday
            {
                Id = 13,
                Name = "Spring Bank Holiday",
                Date = new DateOnly(2026, 5, 25)
            },
            new BankHoliday
            {
                Id = 14,
                Name = "Summer Bank Holiday",
                Date = new DateOnly(2026, 8, 31)
            },
            new BankHoliday
            {
                Id = 15,
                Name = "Christmas Day",
                Date = new DateOnly(2026, 12, 25)
            },
            new BankHoliday
            {
                Id = 16,
                Name = "Boxing Day",
                Date = new DateOnly(2026, 12, 26)
            },
            new BankHoliday
            {
                Id = 17,
                Name = "New Years Day",
                Date = new DateOnly(2027, 1, 1)
            },
            new BankHoliday
            {
                Id = 18,
                Name = "Good Friday",
                Date = new DateOnly(2027, 3, 26)
            },
            new BankHoliday
            {
                Id = 19,
                Name = "Easter Monday",
                Date = new DateOnly(2027, 3, 29)
            },
            new BankHoliday
            {
                Id = 20,
                Name = "Early May Bank Holiday",
                Date = new DateOnly(2027, 5, 3)
            },
            new BankHoliday
            {
                Id = 21,
                Name = "Spring Bank Holiday",
                Date = new DateOnly(2027, 5, 31)
            },
            new BankHoliday
            {
                Id = 22,
                Name = "Summer Bank Holiday",
                Date = new DateOnly(2027, 8, 30)
            },
            new BankHoliday
            {
                Id = 23,
                Name = "Christmas Day",
                Date = new DateOnly(2027, 12, 25)
            },
            new BankHoliday
            {
                Id = 24,
                Name = "Boxing Day",
                Date = new DateOnly(2027, 12, 26)
            },
            new BankHoliday
            {
                Id = 25,
                Name = "New Years Day",
                Date = new DateOnly(2028, 1, 1)
            }
        );
    }
}
