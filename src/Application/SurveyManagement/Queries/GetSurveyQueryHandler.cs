using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.SurveyManagement.Queries;

public class GetSurveyQueryHandler : IRequestHandler<GetSurveyQuery, AllSurveyResult>
{
    private readonly IApplicationDbContext _context;

    public GetSurveyQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AllSurveyResult> Handle(
        GetSurveyQuery request,
        CancellationToken cancellationToken)
    {
        var result = await _context.Surveys
            .Include(s => s.SurveyQuestions)
            .ThenInclude(sq => sq.Question)
            .Include(s=>s.Lecturer)
            .ToListAsync(cancellationToken);
        result = result.OrderByDescending(s => s.Date).ToList();
        return new AllSurveyResult(
            result.Select(
                r => new SurveyResult(
                    r.Id,
                    r.Place,
                    r.Date,
                    r.Subject,
                    r.Lecturer,
                    r.QuestionCount,
                    r.AspectCount,
                    r.SurveyQuestions
                )));
    }
}