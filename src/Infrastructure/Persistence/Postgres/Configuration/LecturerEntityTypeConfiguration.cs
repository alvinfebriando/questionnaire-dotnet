using Bogus;
using Bogus.DataSets;
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
        builder.HasData(LoadLecturer());
    }

    private static IEnumerable<Lecturer> LoadLecturer()
    {
        Randomizer.Seed = new Random(10000);
        var testLecturer = new Faker<Lecturer>("id_ID")
            .RuleFor(l => l.Title, f => f.PickRandom<LecturerTitle>())
            .RuleFor(l => l.Id, f => f.Random.Guid())
            .RuleFor(
                l => l.Name,
                (f, l) => f.Name.FirstName(
                    l.Title.ToString() == "Pak" ? Name.Gender.Male : Name.Gender.Female));
        var lecturers = testLecturer.Generate(30);
        return lecturers;
    }
}