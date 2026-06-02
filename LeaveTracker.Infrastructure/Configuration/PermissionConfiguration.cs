using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.Property(permission => permission.Name).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(permission => permission.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(permission => permission.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(permission => permission.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(permission => permission.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(permission => permission.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Permission
            {
                Id = 1,
                Name = "Administrator"
            },
            new Permission
            {
                Id = 2,
                Name = "Approver"
            },
            new Permission
            {
                Id = 3,
                Name = "Employee"
            }
        );
    }
}

