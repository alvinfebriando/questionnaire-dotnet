using Questionnaire.Application.Rule;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.DocumentPlanning;

public interface IDocumentPlanning
{
    public Content DetermineContent(string place, DateOnly date, string subject, string respondent,
        string lecturer, int questionCount, int aspectCount, IEnumerable<Answer> answers,
        IContentRule rule);

    public Structure DetermineStructure(Point point, IStructureRule rule);
}