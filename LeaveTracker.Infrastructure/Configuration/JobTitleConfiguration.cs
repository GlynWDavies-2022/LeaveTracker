using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class JobTitleConfiguration : IEntityTypeConfiguration<JobTitle>
{
    public void Configure(EntityTypeBuilder<JobTitle> builder)
    {
        builder.Property(jobTitle => jobTitle.Description).HasColumnType("VARCHAR(75)").IsRequired();
        builder.Property(jobTitle => jobTitle.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(jobTitle => jobTitle.CreatedBy).HasColumnType("VARCHAR(30)");
        builder.Property(jobTitle => jobTitle.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(jobTitle => jobTitle.UpdatedBy).HasColumnType("VARCHAR(30)");
        builder.Property(jobTitle => jobTitle.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData(
            new JobTitle
            {
                Id = 1,
                Description = "AI Engineer",
            },
            new JobTitle
            {
                Id = 2,
                Description = "Business Analyst",
            },
            new JobTitle
            {
                Id = 3,
                Description = "Chief Information Officer",
            },
            new JobTitle
            {
                Id = 4,
                Description = "Chief Technology Officer",
            },
            new JobTitle
            {
                Id = 5,
                Description = "Cloud Architect",
            },
            new JobTitle
            {
                Id = 6,
                Description = "Cloud Engineer",
            },
            new JobTitle
            {
                Id = 7,
                Description = "Computer Support Technician",
            },
            new JobTitle
            {
                Id = 8,
                Description = "Data Architect",
            },
            new JobTitle
            {
                Id = 9,
                Description = "Data Scientist",
            },
            new JobTitle
            {
                Id = 10,
                Description = "Database Administrator",
            },
            new JobTitle
            {
                Id = 11,
                Description = "Delivery Manager",
            },
            new JobTitle
            {
                Id = 12,
                Description = "DevOps Engineer",
            },
            new JobTitle
            {
                Id = 13,
                Description = "Engineering Manager",
            },
            new JobTitle
            {
                Id = 14,
                Description = "Helpdesk Analyst",
            },
            new JobTitle
            {
                Id = 15,
                Description = "Infrastructure Engineer",
            },
            new JobTitle
            {
                Id = 16,
                Description = "IT Security Analyst",
            },
            new JobTitle
            {
                Id = 17,
                Description = "Lead Software Engineer",
            },
            new JobTitle
            {
                Id = 18,
                Description = "People Manager",
            },
            new JobTitle
            {
                Id = 19,
                Description = "Product Owner",
            },
            new JobTitle
            {
                Id = 20,
                Description = "Project Manager",
            },
            new JobTitle
            {
                Id = 21,
                Description = "Quality Assurance Engineer",
            },
            new JobTitle
            {
                Id = 22,
                Description = "Report Engineer",
            },
            new JobTitle
            {
                Id = 23,
                Description = "Requirements Engineer",
            },
            new JobTitle
            {
                Id = 24,
                Description = "Scrum Master",
            },
            new JobTitle
            {
                Id = 25,
                Description = "Senior Software Engineer",
            },
            new JobTitle
            {
                Id = 26,
                Description = "Software Engineer",
            },
            new JobTitle
            {
                Id = 27,
                Description = "Solutions Architect",
            }
        );

    }
}
