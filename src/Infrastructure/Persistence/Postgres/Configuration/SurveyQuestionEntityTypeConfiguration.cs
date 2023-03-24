using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres.Configuration;

public class SurveyQuestionEntityTypeConfiguration : IEntityTypeConfiguration<SurveyQuestion>
{
    public void Configure(EntityTypeBuilder<SurveyQuestion> builder)
    {
        builder.HasKey(sq => new { sq.SurveyId, sq.QuestionId });

        builder
            .HasOne<Survey>(sq => sq.Survey)
            .WithMany(s => s.SurveyQuestions)
            .HasForeignKey(sq => sq.SurveyId);

        builder
            .HasOne<Question>(sq => sq.Question)
            .WithMany()
            .HasForeignKey(sq => sq.QuestionId);
    }
}