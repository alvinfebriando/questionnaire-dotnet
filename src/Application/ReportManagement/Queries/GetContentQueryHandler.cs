using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;
using Questionnaire.Application.Service.Report;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.ReportManagement.Queries;

public class GetContentQueryHandler : IRequestHandler<GetContentQuery, Content>
{
    private readonly IApplicationDbContext _context;
    private readonly IReport _report;

    public GetContentQueryHandler(IApplicationDbContext context, IReport report)
    {
        _context = context;
        _report = report;
    }

    public async Task<Content> Handle(GetContentQuery request, CancellationToken cancellationToken)
    {
        var survey = _context.Surveys
            .Include(s => s.SurveyQuestions)
            .ThenInclude(sq => sq.Question)
            .Include(s=>s.Lecturer)
            .FirstOrDefault(s => s.Id == request.SurveyId);
        var answers = await _context.Answers
            .Where(a => a.SurveyQuestion.SurveyId == request.SurveyId)
            .ToListAsync(cancellationToken);
        var questions = survey.SurveyQuestions.Select(sq => sq.Question);
        var content = await _report.GenerateContent(survey, answers, questions);
        return content;
    }
}