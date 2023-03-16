using Microsoft.EntityFrameworkCore;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres;

public class ApplicationDbContext : DbContext
{
    public virtual DbSet<Question> Questions { get; set; }
    public virtual DbSet<Answer> Answers { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>()
            .HasOne<Question>(a => a.Question)
            .WithMany();

        modelBuilder.Entity<Answer>().HasKey(a => a.Id);
        modelBuilder.Entity<Question>().HasKey(q=>q.Id);
    }
}