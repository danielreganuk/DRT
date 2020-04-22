using DRT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DRT.Persistence.Configurations
{
    public class AccountUserConfiguration : IEntityTypeConfiguration<AccountUser>
    {
        public void Configure(EntityTypeBuilder<AccountUser> builder)
        {
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(128);
        }
    }
}