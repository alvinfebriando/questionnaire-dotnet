using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres;

public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
{
    public QuestionRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}