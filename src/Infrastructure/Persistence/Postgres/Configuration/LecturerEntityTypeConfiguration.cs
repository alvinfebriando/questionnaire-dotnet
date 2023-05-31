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
        var seed = new Seed();
        builder.HasData(seed.Lecturers);
    }

    private static IEnumerable<Lecturer> LoadLecturer()
    {
        Randomizer.Seed = new Random(10000);
        var ids = LoadIds().ToList();
        var testLecturer = new Faker<Lecturer>("id_ID")
            .RuleFor(l => l.Title, f => f.PickRandom<LecturerTitle>())
            .RuleFor(
                l => l.Name,
                (f, l) => f.Name.FirstName(
                    l.Title.ToString() == "Pak" ? Name.Gender.Male : Name.Gender.Female));
        var lecturers = testLecturer.Generate(30);
        lecturers = lecturers.Select(
                (l, i) =>
                {
                    l.Id = ids[i];
                    return l;
                })
            .ToList();
        return lecturers;
    }

    private static IEnumerable<Guid> LoadIds()
    {
        return new List<Guid>
        {
            new("f04bd3d8-e2ca-43d9-a59a-de817885fefe"),
            new("4aa23e34-bb92-4d0e-8466-7f0384177deb"),
            new("ea431a62-01f4-4c28-9951-4bec9a6ee1b8"),
            new("31d07541-32c4-41a2-baa5-946c9fad43d1"),
            new("a5edd7a0-d972-4010-913b-3dc33c571a28"),
            new("d6ccde9c-908b-46b6-bc44-8aabc2193c44"),
            new("71ae0e18-95d6-46da-883c-9693b06215c9"),
            new("3b0e6594-0a27-46c7-a809-a3bec05042eb"),
            new("4e1dafb0-9b03-4a72-bba8-485974c27da7"),
            new("d5abbaea-6de1-407d-9caa-46bb341c093c"),
            new("dccbdb0b-e446-4053-bcfe-420c278ad044"),
            new("c8e7d4ff-be7d-4967-8a09-d5d53ee2ad7b"),
            new("99b0a931-4309-4a68-8644-6e8ca111ab05"),
            new("cae206a7-2523-424e-a323-bcba266b3025"),
            new("95850737-7c11-4edc-b3c4-0a60192bea09"),
            new("66123d84-ac2a-4fe6-b9f1-02b0e27d510b"),
            new("24c54838-005f-4676-b033-a220a2eebd93"),
            new("3159cfc5-2ebb-4640-8dd6-968df57bce94"),
            new("0691c1a9-5587-4425-b312-3dae4921a713"),
            new("aac8b5bb-f458-4261-86e3-0196b434e94f"),
            new("5f3c7eb4-6c20-48c9-a63d-6212562b0044"),
            new("72be6dc2-b393-4764-a709-448c5d9f3e2e"),
            new("2876cc93-03c2-4cfd-b3d1-97ebb8d1e01d"),
            new("657e4ff3-32c0-4a50-9428-c715abae675c"),
            new("88027b9e-fb69-482f-9785-6e00d4ea003d"),
            new("c7298bae-a27e-4fcd-9860-88126d0e2cc3"),
            new("4bf9cde4-386c-4b93-84b6-1c2a6b9baadd"),
            new("3daa1662-43bf-42c8-9188-3f82342c194b"),
            new("43d9ce94-281c-4669-963f-216384f80c6b"),
            new("bc89c5c4-2a0e-4a76-9afe-483cb114e2fe"),
        };
    }
}