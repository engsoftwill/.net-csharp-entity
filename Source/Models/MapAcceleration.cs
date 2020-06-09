using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class MapAcceleration : IEntityTypeConfiguration<Acceleration>
    {
        public void Configure(EntityTypeBuilder<Acceleration> builder)
        {
            builder.ToTable("acceleration");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();
            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Slug)
                .HasColumnName("slug")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Challenge_Id)
                .HasColumnName("challenge_id")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Created_At)
                .HasColumnName("created_at")
                .IsRequired();
            builder.HasMany(x => x.Candidates)
                .WithOne(x => x.Accelerations)
                .HasForeignKey(x => x.Acceleration_Id);
        }
    }
}

// os atributos many devem ser instanciados como ICollection e o WithOne devem ser privates