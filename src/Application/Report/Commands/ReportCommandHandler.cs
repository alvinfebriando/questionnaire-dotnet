using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;
using Questionnaire.Application.Service.DocumentPlanning;
using Questionnaire.Application.Service.MicroPlanning;
using Questionnaire.Application.Service.Preprocessing;
using Questionnaire.Application.Service.Realization;

namespace Questionnaire.Application.Report.Commands;

public class ReportCommandHandler : IRequestHandler<ReportCommand, ReportResult>
{
    private readonly IDocumentPlanning _documentPlanning;
    private readonly IMicroPlanning _microPlanning;
    private readonly IRealization _realization;
    private readonly IApplicationDbContext _context;

    public ReportCommandHandler(
        IDocumentPlanning documentPlanning,
        IMicroPlanning microPlanning,
        IRealization realization,
        IApplicationDbContext context)
    {
        _documentPlanning = documentPlanning;
        _microPlanning = microPlanning;
        _realization = realization;
        _context = context;
    }

    public async Task<string> Handle(
        ReportCommand request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var questions = await _context.Questions.ToListAsync(cancellationToken);
        var answers = Preprocessing.Convert(questions, request.Answers).ToList();
        var averageScore = Preprocessing.CalculateAverageScore(answers);

        var content = _documentPlanning.DetermineContent(
            request.Place,
            request.Date,
            request.Subject,
            request.Respondent,
            request.Lecturer,
            averageScore,
            request.QuestionCount,
            request.AspectCount,
            answers);
        var structure = _documentPlanning.DetermineStructure(content.Point);

        _microPlanning.Init(content, structure);
        var topics = _microPlanning.Create();

        _realization.Init(topics);
        _realization.AddFormatter(new CapitalSentenceFormatter());

        var paragraph = _realization.LinguisticRealization();
        return _realization.StructureRealization(paragraph);
    }
}