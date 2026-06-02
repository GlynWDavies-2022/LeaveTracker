using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Configuration;

public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LeaveRequest> builder)
    {
        builder
            .HasOne(leaveRequest => leaveRequest.LeaveRequestDecision)
            .WithMany(leaveRequestDecision => leaveRequestDecision.LeaveRequests)
            .HasForeignKey(leaveRequest => leaveRequest.LeaveRequestDecisionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(leaveRequest => leaveRequest.LeaveRequestDecisionReason)
            .WithMany(leaveRequestDecisionReason => leaveRequestDecisionReason.LeaveRequests)
            .HasForeignKey(leaveRequest => leaveRequest.LeaveRequestDecisionReasonId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(leaveRequest => leaveRequest.LeaveType)
            .WithMany(leaveType => leaveType.LeaveRequests)
            .HasForeignKey(leaveRequest => leaveRequest.LeaveTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(leaveRequest => leaveRequest.Requestor)
            .WithMany(employeeApprover => employeeApprover.RequestedLeaveRequests)
            .HasForeignKey(leaveRequest => leaveRequest.RequestorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(leaveRequest => leaveRequest.Approver)
            .WithMany(employeeApprover => employeeApprover.ApprovedLeaveRequests)
            .HasForeignKey(leaveRequest => leaveRequest.ApproverId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(leaveRequest => leaveRequest.StartDate).HasColumnType("DATE").IsRequired();
        builder.Property(leaveRequest => leaveRequest.EndDate).HasColumnType("DATE").IsRequired();
        builder.Property(leaveRequest => leaveRequest.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(leaveRequest => leaveRequest.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(leaveRequest => leaveRequest.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(leaveRequest => leaveRequest.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(leaveRequest => leaveRequest.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new LeaveRequest
            {
                Id = 1,
                LeaveTypeId = 2,
                StartDate = new DateTime(2025, 12, 1),
                EndDate = new DateTime(2025, 12, 5),
                LeaveRequestDecisionId = 3,
                LeaveRequestDecisionReasonId = 6,
                RequestorId = 1,
                ApproverId = 8
            }
        );
    }
}
