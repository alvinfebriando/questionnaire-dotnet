using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres.Configuration;

public class AnswerUserEntityTypeConfiguration : IEntityTypeConfiguration<AnswerUser>
{
    public void Configure(EntityTypeBuilder<AnswerUser> builder)
    {
        builder.HasKey(a => new { a.AnswerId, a.UserId });

        builder
            .HasOne<Answer>(a => a.Answer)
            .WithMany(a => a.AnswerUsers)
            .HasForeignKey(a => a.AnswerId);

        builder
            .HasOne<User>(a => a.User)
            .WithMany(u => u.AnswerUsers)
            .HasForeignKey(a => a.UserId);
    }
}