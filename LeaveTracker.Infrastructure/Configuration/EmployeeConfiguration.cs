using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveTracker.Infrastructure.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
    {
        builder
            .HasOne(employee => employee.Gender)
            .WithMany(gender => gender.Employees)
            .HasForeignKey(employee => employee.GenderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(employee => employee.Permission)
            .WithMany(permission => permission.Employees)
            .HasForeignKey(employee => employee.PermissionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(employee => employee.Team)
            .WithMany(team => team.Employees)
            .HasForeignKey(employee => employee.TeamId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(employee => employee.Title)
            .WithMany(title => title.Employees)
            .HasForeignKey(employee => employee.TitleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(employee => employee.JobTitle)
            .WithMany(jobTitle => jobTitle.Employees)
            .HasForeignKey(employee => employee.JobTitleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(employee => employee.FirstName).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(employee => employee.MiddleName).HasColumnType("VARCHAR(30)");
        builder.Property(employee => employee.LastName).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(employee => employee.DateOfBirth).HasColumnType("DATE").IsRequired();
        builder.Property(employee => employee.EmailAddress).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(employee => employee.PhoneNumber).HasColumnType("VARCHAR(20)").IsRequired();
        builder.Property(employee => employee.EmploymentStartDate).HasColumnType("DATE").IsRequired();
        builder.Property(employee => employee.EmploymentEndDate).HasColumnType("DATE");
        builder.Property(employee => employee.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(employee => employee.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(employee => employee.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(employee => employee.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(employee => employee.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Employee
            {
                Id = 1,
                TitleId = 1,
                GenderId = 2,
                FirstName = "Marshall",
                MiddleName = "Charles",
                LastName = "Flinkman",
                DateOfBirth = new DateOnly(1970, 12, 29),
                JobTitleId = 25,
                EmailAddress = "marshall.flinkman@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8906",
                PermissionId = 3,
                EmploymentStartDate = new DateOnly(2001, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 2,
                TitleId = 3,
                GenderId = 1,
                FirstName = "Sydney",
                MiddleName = "Anne",
                LastName = "Bristow",
                DateOfBirth = new DateOnly(1972, 4, 17),
                JobTitleId = 25,
                EmailAddress = "sydney.bristow@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8907",
                PermissionId = 3,
                EmploymentStartDate = new DateOnly(2001, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 3,
                TitleId = 3,
                GenderId = 1,
                FirstName = "Rachel",
                MiddleName = "Kelly",
                LastName = "Gibson",
                DateOfBirth = new DateOnly(1980, 1, 8),
                JobTitleId = 25,
                EmailAddress = "rachel.gibson@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8908",
                PermissionId = 3,
                EmploymentStartDate = new DateOnly(2001, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 4,
                TitleId = 1,
                GenderId = 2,
                FirstName = "Marcus",
                MiddleName = "John",
                LastName = "Dixon",
                DateOfBirth = new DateOnly(1951, 8, 14),
                JobTitleId = 18,
                EmailAddress = "marcus.dixon@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8909",
                PermissionId = 3,
                EmploymentStartDate = new DateOnly(1996, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 5,
                TitleId = 3,
                GenderId = 1,
                FirstName = "Francine",
                MiddleName = "Jennifer",
                LastName = "Calfo",
                DateOfBirth = new DateOnly(1971, 8, 6),
                JobTitleId = 2,
                EmailAddress = "francine.calfo@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8910",
                PermissionId = 3,
                EmploymentStartDate = new DateOnly(2001, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 6,
                TitleId = 1,
                GenderId = 2,
                FirstName = "Jackson",
                MiddleName = "Michael",
                LastName = "Bristow",
                DateOfBirth = new DateOnly(1969, 5, 16),
                JobTitleId = 2,
                EmailAddress = "jack.bristow@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8911",
                PermissionId = 3,
                EmploymentStartDate = new DateOnly(1999, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 7,
                TitleId = 3,
                GenderId = 1,
                FirstName = "Lauren",
                MiddleName = "Amber",
                LastName = "Reed",
                DateOfBirth = new DateOnly(1976, 8, 6),
                JobTitleId = 20,
                EmailAddress = "lauren.reed@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8912",
                PermissionId = 3,
                EmploymentStartDate = new DateOnly(2005, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 8,
                TitleId = 3,
                GenderId = 1,
                FirstName = "Irina",
                MiddleName = "Maria",
                LastName = "Derevko",
                DateOfBirth = new DateOnly(1975, 3, 22),
                JobTitleId = 18,
                EmailAddress = "irina.derevko@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8913",
                PermissionId = 2,
                EmploymentStartDate = new DateOnly(2003, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 9,
                TitleId = 1,
                GenderId = 2,
                FirstName = "Michael",
                MiddleName = "John",
                LastName = "Vaughn",
                DateOfBirth = new DateOnly(1978, 11, 27),
                JobTitleId = 17,
                EmailAddress = "michael.vaughn@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8914",
                PermissionId = 1,
                EmploymentStartDate = new DateOnly(2010, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            },
            new Employee
            {
                Id = 10,
                TitleId = 1,
                GenderId = 2,
                FirstName = "Eric",
                MiddleName = "Phillip",
                LastName = "Weisz",
                DateOfBirth = new DateOnly(1966, 7, 11),
                JobTitleId = 27,
                EmailAddress = "@conway.co.uk",
                TeamId = 1,
                PhoneNumber = "0781 455 8914",
                PermissionId = 1,
                EmploymentStartDate = new DateOnly(2010, 1, 2),
                EmploymentEndDate = null,
                WorkPatternId = 1
            }
        );
    }
}
