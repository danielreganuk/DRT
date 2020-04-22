using System;
using System.Collections.Generic;
using System.Text;
using DRT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DRT.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
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
