using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.Answers.Queries;

public class
    GetAnswerBySurveyQueryHandler : IRequestHandler<GetAnswerBySurveyQuery, AllAnswerResult>
{
    private readonly IApplicationDbContext _context;

    public GetAnswerBySurveyQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AllAnswerResult> Handle(
        GetAnswerBySurveyQuery request,
        CancellationToken cancellationToken)
    {
        var answer = await _context.Answers
            .Include(a => a.SurveyQuestion)
            .ThenInclude(sq => sq.Question)
            .Where(a=>a.SurveyQuestion.SurveyId==request.SurveyId)
            .ToListAsync(cancellationToken);
        var answerResult = answer.Select(
            a => new AnswerResult(
                a.Id,
                a.SurveyQuestion.SurveyId,
                a.SurveyQuestion.QuestionId,
                a.Score));
        return new AllAnswerResult(answerResult);
    }
}