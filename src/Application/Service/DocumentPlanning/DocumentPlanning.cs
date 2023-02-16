using Questionnaire.Application.Service.Rule;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.DocumentPlanning;

public class DocumentPlanning : IDocumentPlanning
{
    public Content DetermineContent(
        string place,
        DateOnly date,
        string subject,
        string respondent,
        string lecturer,
        double averageScore,
        int questionCount,
        int aspectCount,
        IEnumerable<Answer> answers,
        IContentRule rule)
    {
        var enumerable = answers.ToList();
        var point = rule.Rule(enumerable);
        return new Content(
            place,
            date,
            subject,
            respondent,
            lecturer,
            averageScore,
            questionCount,
            aspectCount,
            point);
    }

    public Structure DetermineStructure(Point point, IStructureRule rule)
    {
        return rule.Rule(point);
    }
}