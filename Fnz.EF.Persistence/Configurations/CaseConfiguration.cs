using DRT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DRT.Persistence.Configurations
{
    public class CaseConfiguration : IEntityTypeConfiguration<Case>
    {
        public void Configure(EntityTypeBuilder<Case> builder)
        {
            builder.Property(e => e.UserFriendlyId)
                .IsRequired()
                .HasMaxLength(6);

            builder.HasIndex(c => c.UserFriendlyId);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}