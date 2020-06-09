using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class MapSubmission : IEntityTypeConfiguration<Submission>
    {
        public void Configure(EntityTypeBuilder<Submission> builder)
        {
            builder.ToTable("submission");
            builder.HasKey(x => x.User_Id);
            builder.Property(x => x.User_Id)
                .HasColumnName("user_id")
                .IsRequired();
            builder.Property(x => x.Challenge_id)
                .HasColumnName("challenge_id")
                .IsRequired();
            builder.Property(x => x.Score)
                .HasColumnName("score")
                .IsRequired();
            builder.Property(x => x.Created_At)
                .HasColumnName("created_at")
                .IsRequired();
        }
    }
}

