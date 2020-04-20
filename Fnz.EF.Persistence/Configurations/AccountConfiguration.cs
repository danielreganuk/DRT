using DRT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DRT.Persistence.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(e => e.AccountId).HasColumnName("AccountId");

            builder.Property(e => e.AccountName)
                .IsRequired()
                .HasMaxLength(64);

            builder.HasIndex(c => c.AccountName);
        }
    }
}