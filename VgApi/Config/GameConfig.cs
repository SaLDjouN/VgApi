using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VgApi.Models;

namespace VgApi.Config
{
    public class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(k => k.Titre).HasName("PK_Game");
            builder.Property(p => p.Release_Yr).IsRequired();

            builder.Property(p => p.Rating).IsRequired().HasColumnType("int");
            builder.Property(p => p.GenreID).IsRequired();
            builder.Property(p => p.Description).IsRequired();


            //Relation
            builder.HasOne(p=>p.Genre)
            .WithMany(g => g.Games)
            .HasForeignKey(g => g.GenreID)
            .HasConstraintName("FK_Genre_Game");
        }


    }
}
