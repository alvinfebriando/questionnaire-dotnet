using Questionnaire.Application.Service.Rule;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.DocumentPlanning;

public interface IDocumentPlanning
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
        IEnumerable<Answer> answers);

    public Structure DetermineStructure(Point point);
}