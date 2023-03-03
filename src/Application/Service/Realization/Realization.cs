using Questionnaire.Application.Service.Topic;

namespace Questionnaire.Application.Service.Realization;

public class Realization : IRealization
{
    public Realization()
    {
        Formatters = new List<IFormatter>();
    }

    public void Init(IEnumerable<BaseTopic> topics)
    {
        Topics = topics;
    }

    public IList<IFormatter> Formatters { get; set; }
    public IEnumerable<BaseTopic> Topics { get; set; }

    public IEnumerable<string> LinguisticRealization()
    {
        var output = new List<string>();
        foreach (var topic in Topics)
        {
            var sentences = topic.Aggregate();
            sentences = FormatNewLine(sentences, topic.GetType());
            output.AddRange(sentences);
        }

        return Formatters.Aggregate(
            output,
            (current, formatter) => current.Select(formatter.Format).ToList());
    }

    public string StructureRealization(IEnumerable<string> listOfSentence)
    {
        return string.Join("", listOfSentence);
    }

    public void AddFormatter(IFormatter formatter)
    {
        Formatters.Add(formatter);
    }

    private static IList<string> FormatNewLine(IList<string> sentences, Type topic)
    {
        sentences = sentences.Select(s => $"{s} ").ToList();
        var output = sentences;
        if (topic == typeof(PointTopic))
        {
            output[^3] = $"{sentences[^3]}\n";
            output[^2] = $"{sentences[^2].Trim()}\n";
            output[^1] = $"{sentences[^1]}\n\n";
        }
        else if (topic != typeof(OpeningTopic))
        {
            output[^1] += "\n\n";
        }

        return output;
    }
}