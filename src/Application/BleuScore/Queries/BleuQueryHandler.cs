using MediatR;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.DocumentPlanning;
using Questionnaire.Application.Service.MicroPlanning;
using Questionnaire.Application.Service.Preprocessing;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.BleuScore.Queries;

public class BleuQueryHandler : IRequestHandler<BleuQuery, BleuScoreResult>
{
    private readonly IQuestionProvider _questionProvider;
    private readonly IDocumentPlanning _documentPlanning;
    private readonly IMicroPlanning _microPlanning;

    public BleuQueryHandler(
        IQuestionProvider questionProvider,
        IDocumentPlanning documentPlanning,
        IMicroPlanning microPlanning)
    {
        _questionProvider = questionProvider;
        _documentPlanning = documentPlanning;
        _microPlanning = microPlanning;
    }

    public async Task<BleuScoreResult> Handle(
        BleuQuery request,
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

        var output = new List<BleuScoreContainer>();
        foreach (var topic in topics)
        {
            output.AddRange(topic.CalculateBleuScore());
        }

        return new BleuScoreResult(output);
    }
}