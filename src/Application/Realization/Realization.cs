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

    public IEnumerable<string> ConvertToSentence()
    {
        var output = new List<string>();
        foreach (var topic in Topics)
        {
            var sentences = topic.Aggregate();
            sentences = sentences.Select(s => $"{s} ").ToList();
            FormatNewLine(sentences, topic.GetType());
            output.AddRange(sentences);
        }

        return Formatters.Aggregate(output,
            (current, formatter) => current.Select(formatter.Format).ToList());
    }

    private static void FormatNewLine(IList<string> sentences, Type topic)
    {
        if (topic == typeof(PointTopic))
        {
            sentences[^3] = $"{sentences[^3]}\n";
            sentences[^2] = $"{sentences[^2].Trim()}\n";
            sentences[^1] = $"{sentences[^1]}\n";
        }
        else
        {
            sentences[^1] += "\n";
        }
    }

    public void AddFormatter(IFormatter formatter)
    {
        Formatters.Add(formatter);
    }
}