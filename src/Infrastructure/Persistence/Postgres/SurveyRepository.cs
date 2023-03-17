using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres;

public class SurveyRepository : GenericRepository<Survey>, ISurveyRepository
{
    public SurveyRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public override async Task<IEnumerable<Survey>> All()
    {
        return await DbSet.Include(s => s.SurveyQuestions)
            .ThenInclude(sq => sq.Question)
            .ToListAsync();
    }
}