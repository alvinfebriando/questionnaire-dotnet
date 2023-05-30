using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres.Configuration;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        builder
            .HasMany(u => u.Surveys)
            .WithMany(s => s.AnsweredBy);

        builder.HasData(LoadUser());
    }

    private static IEnumerable<User> LoadUser()
    {
        var testUser = new Faker<User>("id_ID")
            .RuleFor(u => u.Id, f => f.Random.Guid())
            .RuleFor(u => u.Name, f => f.Name.FirstName())
            .RuleFor(u => u.Email, (f, u) => $"{u.Name.ToLower()}@usu.ac.id")
            .RuleFor(u => u.Password, (f, u) => $"{u.Name.ToLower()}123");
        var user = testUser.Generate(97);
        user.AddRange(
            new List<User>
            {
                new()
                {
                    Id = new Guid("41CDC211-9AD2-44DF-9AD0-122014CD918B"),
                    Name = "Admin",
                    Email = "admin@usu.ac.id",
                    Password = "admin123"
                },
                new()
                {
                    Id = new Guid("107E9536-5FD4-4B44-891E-9E77EB5CA9AB"),
                    Name = "Alvin",
                    Email = "alvin@usu.ac.id",
                    Password = "alvin123"
                },
                new()
                {
                    Id = new Guid("6E8173DB-65AA-4B55-B030-EEE00927CD39"),
                    Name = "Febriando",
                    Email = "febriando@usu.ac.id",
                    Password = "febriando123"
                }
            });
        return user;
    }
}