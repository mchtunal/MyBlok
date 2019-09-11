using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlok.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlok.DAL.Confing
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(x => x.UserName)
                .IsRequired(false)
                .HasMaxLength(256);

            builder.Property(x => x.PasswordHash)
               .IsRequired();

        }

    }
}
