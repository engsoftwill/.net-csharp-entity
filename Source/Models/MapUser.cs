using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Codenation.Challenge.Models
{
    public class MapUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();
            builder.Property(x => x.Full_Name)
                .HasColumnName("full_name")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Email)
                .HasColumnName("email")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Nickname)
                .HasColumnName("nickname")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Password)
                .HasColumnName("password")
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(x => x.Created_At)
                .HasColumnName("created_at")
                .IsRequired();
            builder.HasMany(x => x.Candidates)
                .WithOne(x => x.Users)
                .HasForeignKey(x => x.User_Id);
            builder.HasMany(x => x.Submissions)
                .WithOne(x => x.Users)
                .HasForeignKey(x => x.User_Id);
        }
    }
}

