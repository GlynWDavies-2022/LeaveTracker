using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class LeaveRequestDecisionReasonConfiguration : IEntityTypeConfiguration<LeaveRequestDecisionReason>
{
    public void Configure(EntityTypeBuilder<LeaveRequestDecisionReason> builder)
    {
        builder.Property(leaveRequestDecisionReason => leaveRequestDecisionReason.Description).HasColumnType("VARCHAR(100)").IsRequired();
        builder.Property(leaveRequestDecisionReason => leaveRequestDecisionReason.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(leaveRequestDecisionReason => leaveRequestDecisionReason.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(leaveRequestDecisionReason => leaveRequestDecisionReason.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(leaveRequestDecisionReason => leaveRequestDecisionReason.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(leaveRequestDecisionReason => leaveRequestDecisionReason.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new LeaveRequestDecisionReason
            {
                Id = 1,
                Description = "Operational Requirements"
            },
            new LeaveRequestDecisionReason
            {
                Id = 2,
                Description = "Insufficient Leave Balance"
            },
            new LeaveRequestDecisionReason
            {
                Id = 3,
                Description = "Insufficient Notice Provided"
            },
            new LeaveRequestDecisionReason
            {
                Id = 4,
                Description = "Leave Entitlement Exceeded"
            },
            new LeaveRequestDecisionReason
            {
                Id = 5,
                Description = "Company Policy Breach"
            },
            new LeaveRequestDecisionReason
            {
                Id = 6,
                Description = "Pending"
            }
        );
    }
}

