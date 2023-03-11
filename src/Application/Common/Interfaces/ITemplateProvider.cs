namespace Questionnaire.Application.Common.Interfaces;

public interface ITemplateProvider
{
    protected Dictionary<string, string> Template { get; set; }

    public string Get(string key)
    {
        return Template[key];
    }
}