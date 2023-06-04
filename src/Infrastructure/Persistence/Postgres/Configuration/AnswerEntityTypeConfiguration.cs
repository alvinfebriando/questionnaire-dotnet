using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres.Configuration;

public class AnswerEntityTypeConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).ValueGeneratedOnAdd();
        builder
            .HasOne<SurveyQuestion>(a => a.SurveyQuestion)
            .WithMany();
        builder.HasOne<User>(a => a.AnsweredByUser)
            .WithMany(u => u.Answers);

        var seed = new Seed();
        var answers = seed.Answers.Select(
            a => new
            {
                a.Id,
                SurveyQuestionSurveyId = a.SurveyQuestion.SurveyId,
                SurveyQuestionQuestionId = a.SurveyQuestion.QuestionId,
                a.Score
            });
        builder.HasData(answers);
    }
}