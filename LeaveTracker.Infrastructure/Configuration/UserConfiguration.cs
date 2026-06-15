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
        builder.Property(user => user.DisplayHash).HasColumnType("VARBINARY(64)").IsRequired();
        builder.Property(user => user.PasswordSalt).HasColumnType("VARBINARY(64)").IsRequired();
    }
}
