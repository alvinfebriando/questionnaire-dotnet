using Questionnaire.Application.Service.DocumentPlanning;
using Questionnaire.Application.Service.MicroPlanning;
using Questionnaire.Application.Service.Realization;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Report;

public class Report : IReport
{
    private readonly IDocumentPlanning _documentPlanning;
    private readonly IMicroPlanning _microPlanning;
    private readonly IRealization _realization;

    public Report(
        IDocumentPlanning documentPlanning,
        IMicroPlanning microPlanning,
        IRealization realization)
    {
        _documentPlanning = documentPlanning;
        _microPlanning = microPlanning;
        _realization = realization;
    }

    public async Task<string> GenerateReport(
        Domain.Entities.Survey survey,
        IEnumerable<Answer> answers,
        IEnumerable<Question> questions)
    {
        var groupedAnswer = answers
            .GroupBy(a => a.SurveyQuestion.QuestionId)
            .Select(
                g => new { QuestionId = g.Key, Score = Math.Round(g.Average(a => a.Score), 2) });
        var averagedScore = groupedAnswer
            .Select(g => new AnswerScore(g.QuestionId, g.Score)).ToList();
        var totalAverageScore = Math.Round(averagedScore.Average(a => a.Score), 2);

        var convertedAnswer = Preprocessing.Preprocessing.Convert(questions, averagedScore);

        var content = _documentPlanning.DetermineContent(
            survey.Place,
            survey.Date,
            survey.Subject,
            survey.Respondent,
            survey.Lecturer,
            totalAverageScore,
            survey.QuestionCount,
            survey.AspectCount,
            convertedAnswer
        );
        var structure = _documentPlanning.DetermineStructure(content.Point);

        _microPlanning.Init(content, structure);
        var topics = _microPlanning.Create();

        _realization.Init(topics);
        _realization.AddFormatter(new CapitalSentenceFormatter());

        var paragraph = _realization.LinguisticRealization();
        return _realization.StructureRealization(paragraph);
    }
}