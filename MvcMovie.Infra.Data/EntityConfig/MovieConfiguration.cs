using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcMovie.Domain;

namespace MvcMovie.Infra.Data
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        void IEntityTypeConfiguration<Movie>.Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(x => x.Genre)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.Rating)
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnType("decimal(18, 2)");

            builder.Property(x => x.Summary)
                .HasMaxLength(255);
        }
    }
}
