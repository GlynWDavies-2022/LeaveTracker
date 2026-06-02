using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder
            .HasOne(office => office.Company)
            .WithMany(company => company.Offices)
            .HasForeignKey(office => office.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(office => office.Name).HasColumnType("VARCHAR(40)").IsRequired();
        builder.Property(office => office.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(office => office.CreatedBy).HasColumnType("VARCHAR(40)").IsRequired();
        builder.Property(office => office.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(office => office.UpdatedBy).HasColumnType("VARCHAR(40)").IsRequired();
        builder.Property(office => office.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Office
            {
                Id = 1,
                Name = "London",
                CompanyId = 1
            }
        );

    }
}
