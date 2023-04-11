using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.AnswerManagement.Queries;

public class GetChartQueryHandler : IRequestHandler<GetChartQuery, ChartResult>
{
    private readonly IApplicationDbContext _context;

    public GetChartQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ChartResult> Handle(
        GetChartQuery request,
        CancellationToken cancellationToken)
    {
        var answers = _context.Answers
            .Where(a => a.SurveyQuestion.SurveyId == request.SurveyId)
            .GroupBy(a => a.SurveyQuestion.QuestionId)
            .Select(
                g => new
                {
                    Question =
                        new
                        {
                            g.First().SurveyQuestion.Question.Title,
                            g.First().SurveyQuestion.QuestionId
                        },
                    Scores = g.GroupBy(a => a.Score)
                        .Select(s => new { Score = s.Key, Count = s.Count() })
                        .OrderBy(a => a.Score)
                        .ToList()
                })
            .ToList();
        return new ChartResult(answers);
    }
}