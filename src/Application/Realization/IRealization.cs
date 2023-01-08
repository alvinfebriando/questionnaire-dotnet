using Questionnaire.Application.Topic;

namespace Questionnaire.Application.Realization;

public interface IRealization
{
    IList<IFormatter> Formatters { get; set; }
    IEnumerable<BaseTopic> Topics { get; set; }
    IEnumerable<string> ConvertToSentence();
    void AddFormatter(IFormatter formatter);
}