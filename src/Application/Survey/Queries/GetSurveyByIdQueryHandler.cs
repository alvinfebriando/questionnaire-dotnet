using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.Survey.Queries;

public class GetSurveyByIdQueryHandler : IRequestHandler<GetSurveyByIdQuery, SurveyResult>
{
    private readonly IApplicationDbContext _context;

    public GetSurveyByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<SurveyResult> Handle(
        GetSurveyByIdQuery request,
        CancellationToken cancellationToken)
    {
        var result = await _context.Surveys.Include(s => s.SurveyQuestions)
            .ThenInclude(sq => sq.Question)
            .FirstAsync(s => s.Id == request.Id, cancellationToken);
        return new SurveyResult(
            result.Id,
            result.Place,
            result.Date,
            result.Subject,
            result.Respondent,
            result.Lecturer,
            result.QuestionCount,
            result.AspectCount,
            result.SurveyQuestions);
    }
}