using Questionnaire.Application.Topic;

namespace Questionnaire.Application.Realization;

public interface IRealization
{
    IList<IFormatter> Formatters { get; set; }
    IEnumerable<BaseTopic> Topics { get; set; }
    IEnumerable<string> LingusticRealization();
    string StructureRealization(IEnumerable<string> listOfSentence);
    void AddFormatter(IFormatter formatter);
}