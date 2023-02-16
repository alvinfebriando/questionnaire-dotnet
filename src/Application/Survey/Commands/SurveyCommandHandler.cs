using MediatR;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.DocumentPlanning;
using Questionnaire.Application.Service.MicroPlanning;
using Questionnaire.Application.Service.Preprocessing;
using Questionnaire.Application.Service.Realization;
using Questionnaire.Application.Service.Rule;

namespace Questionnaire.Application.Survey.Commands;

public class SurveyCommandHandler : IRequestHandler<SurveyCommand, IEnumerable<string>>
{
    private readonly IQuestionProvider _questionProvider;
    private readonly IDocumentPlanning _documentPlanning;
    private readonly IMicroPlanning _microPlanning;
    private readonly IRealization _realization;

    public SurveyCommandHandler(
        IQuestionProvider questionProvider,
        IDocumentPlanning documentPlanning,
        IMicroPlanning microPlanning,
        IRealization realization)
    {
        _questionProvider = questionProvider;
        _documentPlanning = documentPlanning;
        _microPlanning = microPlanning;
        _realization = realization;
    }

    public async Task<IEnumerable<string>> Handle(
        SurveyCommand request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var answers = Preprocessing.Convert(_questionProvider, request.Answers).ToList();
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
        return paragraph;
    }
}