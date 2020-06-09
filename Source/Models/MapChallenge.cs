using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class MapChallenge : IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> builder)
        {
            builder.ToTable("challenge");
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
            builder.Property(x => x.Created_At)
                .HasColumnName("created_at")
                .IsRequired();
            builder.HasMany(x => x.Accelerations)
                .WithOne(x => x.Challenges)
                .HasForeignKey(x => x.Challenge_Id);
            builder.HasMany(x => x.Submissions)
                .WithOne(x => x.Challenges)
                .HasForeignKey(x => x.Challenge_id);
        }
    }
}