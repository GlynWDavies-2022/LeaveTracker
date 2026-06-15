using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(user => user.DisplayName).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(user => user.EmailAddress).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(user => user.PasswordHash).HasColumnType("VARBINARY(MAX)").IsRequired();
        builder.Property(user => user.PasswordSalt).HasColumnType("VARBINARY(MAX)").IsRequired();
    }
}
