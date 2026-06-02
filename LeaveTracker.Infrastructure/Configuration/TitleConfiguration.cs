using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class TitleConfiguration : IEntityTypeConfiguration<Title>
{
    public void Configure(EntityTypeBuilder<Title> builder)
    {
        builder.Property(title => title.Description).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(title => title.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(title => title.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(title => title.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(title => title.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(title => title.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData(
            new Title
            {
                Id = 1,
                Description = "Mr"
            },
            new Title
            {
                Id = 2,
                Description = "Mrs"
            },
            new Title
            {
                Id = 3,
                Description = "Miss"
            },
            new Title
            {
                Id = 4,
                Description = "Ms"
            },
            new Title
            {
                Id = 5,
                Description = "Mx"
            },
            new Title
            {
                Id = 6,
                Description = "Dr"
            }
        );
    }
}