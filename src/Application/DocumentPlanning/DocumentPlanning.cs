using Questionnaire.Application.Rule;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.DocumentPlanning;

public class DocumentPlanning : IDocumentPlanning
{
    public Content DetermineContent(string place, DateOnly date, string subject, string respondent,
        string lecturer, int questionCount, int aspectCount, IEnumerable<Answer> answers,
        IContentRule rule)
    {
        var enumerable = answers.ToList();
        var point = rule.Rule(enumerable);
        var averageScore = Math.Round(enumerable.Select(x => x.Score).Average(), 2);
        return new Content(place, date, subject, respondent, lecturer, averageScore, questionCount,
            aspectCount, point);
    }

    public Structure DetermineStructure(Point point, IStructureRule rule)
    {
        return rule.Rule(point);
    }
}