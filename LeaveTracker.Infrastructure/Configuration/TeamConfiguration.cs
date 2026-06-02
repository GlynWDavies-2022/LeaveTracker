using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Configuration;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Team> builder)
    {
        builder
            .HasOne(team => team.Office)
            .WithMany(office => office.Teams)
            .HasForeignKey(team => team.OfficeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(team => team.Name).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(team => team.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(team => team.CreatedBy).HasColumnType("VARCHAR(40)").IsRequired();
        builder.Property(team => team.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(team => team.UpdatedBy).HasColumnType("VARCHAR(40)").IsRequired();
        builder.Property(team => team.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Team
            {
                Id = 1,
                Name = "Finance",
                OfficeId = 1
            },
            new Team
            {
                Id = 2,
                Name = "People Services",
                OfficeId = 1
            }
        );

    }
}
