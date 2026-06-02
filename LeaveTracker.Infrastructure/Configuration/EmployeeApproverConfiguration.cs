using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Configuration;

public class EmployeeApproverConfiguration : IEntityTypeConfiguration<EmployeeApprover>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<EmployeeApprover> builder)
    {
        builder.Property(employeeApprover => employeeApprover.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(employeeApprover => employeeApprover.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(employeeApprover => employeeApprover.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(employeeApprover => employeeApprover.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(employeeApprover => employeeApprover.IsActive).HasColumnType("BIT").IsRequired();

        builder
            .HasOne(employeeApprover => employeeApprover.Employee)
            .WithMany(employee => employee.Requestors)
            .HasForeignKey(employeeApprover => employeeApprover.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(employeeApprover => employeeApprover.Approver)
            .WithMany(employee => employee.Approvers)
            .HasForeignKey(employeeApprover => employeeApprover.ApproverId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData
        (
            new EmployeeApprover
            {
                Id = 1,
                EmployeeId = 1,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 2,
                EmployeeId = 2,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 3,
                EmployeeId = 3,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 4,
                EmployeeId = 4,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 5,
                EmployeeId = 5,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 6,
                EmployeeId = 6,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 7,
                EmployeeId = 7,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 8,
                EmployeeId = 8,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 9,
                EmployeeId = 9,
                ApproverId = 8
            },
            new EmployeeApprover
            {
                Id = 10,
                EmployeeId = 10,
                ApproverId = 8
            }
        );

    }
}