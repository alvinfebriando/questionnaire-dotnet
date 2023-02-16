using Questionnaire.Application.Service.Rule;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.DocumentPlanning;

public class DocumentPlanning : IDocumentPlanning
{
    private readonly IContentRule _contentRule;
    private readonly IStructureRule _structureRule;

    public DocumentPlanning(IContentRule contentRule, IStructureRule structureRule)
    {
        _contentRule = contentRule;
        _structureRule = structureRule;
    }

    public Content DetermineContent(
        string place,
        DateOnly date,
        string subject,
        string respondent,
        string lecturer,
        double averageScore,
        int questionCount,
        int aspectCount,
        IEnumerable<Answer> answers)
    {
        var enumerable = answers.ToList();
        var point = _contentRule.Rule(enumerable);
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

    public Structure DetermineStructure(Point point)
    {
        return _structureRule.Rule(point);
    }
}