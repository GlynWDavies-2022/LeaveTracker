using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder
            .HasOne(company => company.Country)
            .WithMany(country => country.Companies)
            .HasForeignKey(company => company.CountryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(company => company.Name).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(company => company.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(company => company.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(company => company.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(company => company.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(company => company.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Company
            {
                Id = 1,
                Name = "Conway",
                CountryId = 1
            }
        );

    }
}
