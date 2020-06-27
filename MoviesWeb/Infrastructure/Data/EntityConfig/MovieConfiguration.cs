using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Infrastructure.Data.EntityConfig
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id);
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(150);
            builder.Property(p => p.Image).HasColumnName("image").HasMaxLength(200);
        }
    }
}
