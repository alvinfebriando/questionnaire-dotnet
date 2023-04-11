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
        Survey survey,
        IEnumerable<Answer> answers,
        IEnumerable<Question> questions)
    {
        var listOfAnswer = answers.ToList();
        var groupAnswerByQuestion =
            Preprocessing.Preprocessing.AverageOfEachQuestion(listOfAnswer, questions).ToList();
        var totalAverageScore = Math.Round(groupAnswerByQuestion.Average(a => a.Score),2);

        var respondent = listOfAnswer.GroupBy(a => a.SurveyQuestion.QuestionId).First().Count();
        var lecturer = $"{survey.Lecturer.Title} {survey.Lecturer.Name}";

        var content = _documentPlanning.DetermineContent(
            survey.Place,
            survey.Date,
            survey.Subject,
            respondent.ToString(),
            lecturer,
            totalAverageScore,
            survey.QuestionCount,
            survey.AspectCount,
            groupAnswerByQuestion
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