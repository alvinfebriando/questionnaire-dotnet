using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres;

public class SurveyRepository : GenericRepository<Survey>, ISurveyRepository
{
    public SurveyRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}