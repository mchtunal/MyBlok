using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlok.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlok.DAL.Confing
{
    class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(x => x.Content)
                .IsRequired(false);

            builder.Property(x => x.CategoryId)
               .IsRequired();

            builder.Property(x => x.Auther)
               .IsRequired();
        }

    }
}
