namespace LeaveTracker.Infrastructure.Configuration;

using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class WorkPatternConfiguration : IEntityTypeConfiguration<WorkPattern>
{
    public void Configure(EntityTypeBuilder<WorkPattern> builder)
    {
        builder.Property(workPattern => workPattern.Name).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(workPattern => workPattern.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(workPattern => workPattern.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(workPattern => workPattern.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(workPattern => workPattern.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(workPattern => workPattern.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData(
            new WorkPattern
            {
                Id = 1,
                Name = "Standard"
            }
        );
    }
}