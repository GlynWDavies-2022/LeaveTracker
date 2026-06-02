using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder
            .HasMany(language => language.Countries)
            .WithOne(country => country.Language)
            .HasForeignKey(country => country.LanguageId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(language => language.ISOCode).HasColumnType("CHAR(3)").IsRequired();
        builder.Property(language => language.Name).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(language => language.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(language => language.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(language => language.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(language => language.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(language => language.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Language
            {
                Id = 1,
                ISOCode = "ENG",
                Name = "English"
            }
        );
    }
}
