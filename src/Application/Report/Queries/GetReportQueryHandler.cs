using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;
using Questionnaire.Application.Service.Report;

namespace Questionnaire.Application.Report.Queries;

public class GetReportQueryHandler : IRequestHandler<GetReportQuery, ReportResult>
{
    private readonly IApplicationDbContext _context;
    private readonly IReport _report;

    public GetReportQueryHandler(IApplicationDbContext context, IReport report)
    {
        _context = context;
        _report = report;
    }

    public async Task<ReportResult> Handle(GetReportQuery request, CancellationToken cancellationToken)
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
        var report = await _report.GenerateReport(survey, answers, questions);
        return new ReportResult(report);
    }
}