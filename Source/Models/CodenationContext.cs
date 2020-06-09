using Microsoft.EntityFrameworkCore;
using Codenation.Challenge.Models;

namespace Codenation.Challenge.Models
{
    public class CodenationContext : DbContext
    {
        public DbSet<Acceleration> Accelerations { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Codenation;Trusted_Connection=True");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Codenation.Challenge.Models.MapAcceleration());
            modelBuilder.ApplyConfiguration(new Codenation.Challenge.Models.MapCandidate());
            modelBuilder.ApplyConfiguration(new Codenation.Challenge.Models.MapChallenge());
            modelBuilder.ApplyConfiguration(new Codenation.Challenge.Models.MapCompany());
            modelBuilder.ApplyConfiguration(new Codenation.Challenge.Models.MapSubmission());
            modelBuilder.ApplyConfiguration(new Codenation.Challenge.Models.MapUser());
        }
    }
}