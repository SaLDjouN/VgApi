using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VgApi.Models;

namespace VgApi.Config
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();

            builder.HasMany(p => p.Games)
            .WithOne(g => g.Genre)
            .HasForeignKey(g => g.GenreID)
            .HasConstraintName("FK_Geenre_Game");

        }
    }
}
