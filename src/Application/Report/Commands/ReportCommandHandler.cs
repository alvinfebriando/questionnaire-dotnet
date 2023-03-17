using MediatR;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.DocumentPlanning;
using Questionnaire.Application.Service.MicroPlanning;
using Questionnaire.Application.Service.Preprocessing;
using Questionnaire.Application.Service.Realization;

namespace Questionnaire.Application.Report.Commands;

public class ReportCommandHandler : IRequestHandler<ReportCommand, string>
{
    private readonly IDocumentPlanning _documentPlanning;
    private readonly IMicroPlanning _microPlanning;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRealization _realization;

    public ReportCommandHandler(
        IDocumentPlanning documentPlanning,
        IMicroPlanning microPlanning,
        IRealization realization,
        IUnitOfWork unitOfWork)
    {
        _documentPlanning = documentPlanning;
        _microPlanning = microPlanning;
        _realization = realization;
        _unitOfWork = unitOfWork;
    }

    public async Task<string> Handle(
        ReportCommand request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var answers = (await Preprocessing.Convert(_unitOfWork.QuestionRepository, request.Answers)).ToList();
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