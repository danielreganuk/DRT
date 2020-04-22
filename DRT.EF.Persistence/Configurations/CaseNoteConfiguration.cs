using DRT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DRT.Persistence.Configurations
{
    public class CaseNoteConfiguration : IEntityTypeConfiguration<CaseNote>
    {
        public void Configure(EntityTypeBuilder<CaseNote> builder)
        {
            builder.Property(e => e.Content)
                .IsRequired();
        }
    }
}