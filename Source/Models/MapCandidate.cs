using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models

{
    public class MapCandidate : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable("candidate");
            builder.HasKey(x => x.User_Id);
            builder.Property(x => x.User_Id)
                .HasColumnName("user_id")
                .IsRequired();
            builder.Property(x => x.Acceleration_Id)
                .HasColumnName("acceleration_id")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Company_Id)
                .HasColumnName("company_id")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Status)
                .HasColumnName("status")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Created_At)
                .HasColumnName("created_at")
                .IsRequired();
        }
    }
}
