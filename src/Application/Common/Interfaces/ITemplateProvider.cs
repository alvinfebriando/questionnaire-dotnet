namespace Questionnaire.Application.Common.Interfaces;

public interface ITemplateProvider
{
    public Dictionary<string, string> Template { get; set; }
}