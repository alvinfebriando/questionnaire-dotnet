using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Infrastructure.Persistence.Postgres.Configuration;

public class LecturerEntityTypeConfiguration : IEntityTypeConfiguration<Lecturer>
{
    public void Configure(EntityTypeBuilder<Lecturer> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Id).ValueGeneratedOnAdd();
        builder.Property(l => l.Title)
            .HasConversion(
                v => v.ToString().Humanize(LetterCasing.Sentence),
                v => (LecturerTitle)Enum.Parse(typeof(LecturerTitle), v.Dehumanize()));
    }
}