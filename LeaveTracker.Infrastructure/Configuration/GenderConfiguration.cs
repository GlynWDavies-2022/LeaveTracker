using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class GenderConfiguration : IEntityTypeConfiguration<Gender>
{
    public void Configure(EntityTypeBuilder<Gender> builder)
    {
        builder.Property(gender => gender.Description).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(gender => gender.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(gender => gender.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(gender => gender.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(gender => gender.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(gender => gender.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Gender
            {
                Id = 1,
                Description = "Female"
            },
            new Gender
            {
                Id = 2,
                Description = "Male"
            },
            new Gender
            {
                Id = 3,
                Description = "Agender"
            },
            new Gender
            {
                Id = 4,
                Description = "Omnigender"
            }
        );

    }
}
