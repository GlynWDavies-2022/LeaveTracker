using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class LeaveRequestDecisionConfiguration : IEntityTypeConfiguration<LeaveRequestDecision>
{
    public void Configure(EntityTypeBuilder<LeaveRequestDecision> builder)
    {
        builder.Property(leaveRequestDecision => leaveRequestDecision.Description).HasColumnType("VARCHAR(100)").IsRequired();
        builder.Property(leaveRequestDecision => leaveRequestDecision.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(leaveRequestDecision => leaveRequestDecision.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(leaveRequestDecision => leaveRequestDecision.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(leaveRequestDecision => leaveRequestDecision.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(leaveRequestDecision => leaveRequestDecision.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new LeaveRequestDecision
            {
                Id = 1,
                Description = "Approved"
            },
            new LeaveRequestDecision
            {
                Id = 2,
                Description = "Declined"
            },
            new LeaveRequestDecision
            {
                Id = 3,
                Description = "Pending"
            }
        );
    }
}