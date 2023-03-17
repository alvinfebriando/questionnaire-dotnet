using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Infrastructure.Persistence.Postgres;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        QuestionRepository = new QuestionRepository(_dbContext);
        SurveyRepository = new SurveyRepository(_dbContext);
    }

    public IQuestionRepository QuestionRepository { get; set; }
    public ISurveyRepository SurveyRepository { get; set; }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}