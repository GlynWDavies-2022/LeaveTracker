namespace LeaveTracker.Infrastructure.Configuration;

using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
{
    public void Configure(EntityTypeBuilder<LeaveType> builder)
    {
        builder.Property(leaveType => leaveType.Id).HasColumnType("INT").IsRequired();
        builder.Property(leaveType => leaveType.Name).HasColumnType("VARCHAR(100)").IsRequired();
        builder.Property(leaveType => leaveType.CreatedAt).HasColumnType("DATETIME").HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(leaveType => leaveType.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(leaveType => leaveType.UpdatedAt).HasColumnType("DATETIME").HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(leaveType => leaveType.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(leaveType => leaveType.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new LeaveType
            {
                Id = 1,
                Name = "Adoption Leave"
            },
            new LeaveType
            {
                Id = 2,
                Name = "Annual Leave"
            },
            new LeaveType
            {
                Id = 3,
                Name = "Bank Holiday"
            },
            new LeaveType
            {
                Id = 4,
                Name = "Carers Leave"
            },
            new LeaveType
            {
                Id = 5,
                Name = "Emergency Dependant Leave"
            },
            new LeaveType
            {
                Id = 6,
                Name = "Garden Leave"
            },
            new LeaveType
            {
                Id = 7,
                Name = "Maternity Leave"
            },
            new LeaveType
            {
                Id = 8,
                Name = "Parental Bereavement Leave"
            },
            new LeaveType
            {
                Id = 9,
                Name = "Paternity Leave"
            },
            new LeaveType
            {
                Id = 10,
                Name = "Public Duty Leave"
            },
            new LeaveType
            {
                Id = 11,
                Name = "Sabbatical Leave"
            },
            new LeaveType
            {
                Id = 12,
                Name = "Shared Parental Leave"
            },
            new LeaveType
            {
                Id = 13,
                Name = "Sick Leave"
            },
            new LeaveType
            {
                Id = 14,
                Name = "TOIL Leave"
            },
            new LeaveType
            {
                Id = 15,
                Name = "Unpaid Parental Leave"
            },
            new LeaveType
            {
                Id = 16,
                Name = "Unpaid Leave"
            },
            new LeaveType
            {
                Id = 17,
                Name = "Birthday Leave"
            }
        );
    }
}
