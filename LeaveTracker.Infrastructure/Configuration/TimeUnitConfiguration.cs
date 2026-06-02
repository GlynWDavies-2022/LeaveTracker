namespace LeaveTracker.Infrastructure.Configuration;

using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TimeUnitConfiguration : IEntityTypeConfiguration<TimeUnit>
{
    public void Configure(EntityTypeBuilder<TimeUnit> builder)
    {
        builder.Property(timeUnit => timeUnit.Name).HasColumnType("VARCHAR(20)").IsRequired();
        builder.Property(timeUnit => timeUnit.CreatedAt).HasColumnType("DATETIME").IsRequired().IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(timeUnit => timeUnit.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(timeUnit => timeUnit.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(timeUnit => timeUnit.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(timeUnit => timeUnit.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new TimeUnit
            {
                Id = 1,
                Name = "Year"
            },
            new TimeUnit
            {
                Id = 2,
                Name = "Quarter"
            },
            new TimeUnit
            {
                Id = 3,
                Name = "Month"
            },
            new TimeUnit
            {
                Id = 4,
                Name = "Week"
            },
            new TimeUnit
            {
                Id = 5,
                Name = "Day"
            },
            new TimeUnit
            {
                Id = 6,
                Name = "Hour"
            }
        );
    }
}
