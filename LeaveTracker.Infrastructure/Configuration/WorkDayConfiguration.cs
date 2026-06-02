using LeaveTracker.Domain.Entities;
using LeaveTracker.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class WorkDayConfiguration : IEntityTypeConfiguration<WorkDay>
{
    public void Configure(EntityTypeBuilder<WorkDay> builder)
    {
        builder
            .HasOne(workDay => workDay.WorkPattern)
            .WithMany(workPattern => workPattern.WorkDays)
            .HasForeignKey(workDay => workDay.WorkPatternId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(workDay => workDay.Day).HasColumnType("TINYINT").IsRequired();
        builder.Property(workDay => workDay.StartTime).HasColumnType("TIME").IsRequired();
        builder.Property(workDay => workDay.EndTime).HasColumnType("TIME").IsRequired();
        builder.Property(workDay => workDay.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(workDay => workDay.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(workDay => workDay.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(workDay => workDay.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(workDay => workDay.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData(
            new WorkDay
            {
                Id = 1,
                Day = WeekDay.Monday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(17, 30, 0),
                WorkPatternId = 1
            },
            new WorkDay
            {
                Id = 2,
                Day = WeekDay.Tuesday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(17, 30, 0),
                WorkPatternId = 1
            },
            new WorkDay
            {
                Id = 3,
                Day = WeekDay.Wednesday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(17, 30, 0),
                WorkPatternId = 1
            },
            new WorkDay
            {
                Id = 4,
                Day = WeekDay.Thursday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(17, 30, 0),
                WorkPatternId = 1
            },
            new WorkDay
            {
                Id = 5,
                Day = WeekDay.Friday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(17, 30, 0),
                WorkPatternId = 1
            }
        );
    }
}
