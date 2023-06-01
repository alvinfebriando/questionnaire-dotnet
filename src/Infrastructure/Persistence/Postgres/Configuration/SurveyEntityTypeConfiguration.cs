using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres.Configuration;

public class SurveyEntityTypeConfiguration : IEntityTypeConfiguration<Survey>
{
    public void Configure(EntityTypeBuilder<Survey> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).ValueGeneratedOnAdd();

        var seed = new Seed();
        var surveys = seed.Surveys.Select(
            s => new
            {
                s.Id,
                s.Place,
                s.Date,
                s.Subject,
                LecturerId = s.Lecturer.Id,
                s.AspectCount,
                s.QuestionCount,
            });
        builder.HasData(surveys);
    }
}