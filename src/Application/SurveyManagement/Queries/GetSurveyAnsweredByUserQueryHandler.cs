using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.SurveyManagement.Queries;

public class
    GetSurveyAnsweredByUserQueryHandler : IRequestHandler<GetSurveyAnsweredByUserQuery,
        IEnumerable<Guid>>
{
    private readonly IApplicationDbContext _context;

    public GetSurveyAnsweredByUserQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Guid>> Handle(
        GetSurveyAnsweredByUserQuery request,
        CancellationToken cancellationToken)
    {
        var answers = await _context.Answers
            .Include(a => a.AnsweredByUser)
            .Include(a => a.SurveyQuestion)
            .Where(a=>a.AnsweredByUser.Id == request.UserId)
            .ToListAsync(cancellationToken);

        return answers.Select(s => s.SurveyQuestion.SurveyId);
    }
}