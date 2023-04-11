using Microsoft.EntityFrameworkCore;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Data;

public interface IApplicationDbContext
{
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Survey> Surveys { get; set; }
    public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
    public DbSet<Lecturer> Lecturers { get; set; }
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}