using Questionnaire.Application.Topic;

namespace Questionnaire.Application.Realization;

public class Realization : IRealization
{
    public Realization(IEnumerable<BaseTopic> topics)
    {
        Topics = topics;
        Formatters = new List<IFormatter>();
    }

    public IList<IFormatter> Formatters { get; set; }
    public IEnumerable<BaseTopic> Topics { get; set; }

    public List<string> ConvertToSentence()
    {
        var output = new List<string>();
        foreach (var topic in Topics)
        {
            var sentences = topic.Aggregate();
            output.AddRange(sentences);
        }

        AddFormatter();

        return Formatters.Aggregate(output,
            (current, formatter) => current.Select(formatter.Format).ToList());
    }

    private void AddFormatter()
    {
        Formatters.Add(new TrimFormatter());
    }
}