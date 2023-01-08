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
            sentences[^1] += "\n";
            output.AddRange(sentences);
        }

        // var o = output.SelectMany(o => o.Split(". ", StringSplitOptions.RemoveEmptyEntries)).ToList();

        return Formatters.Aggregate(output,
            (current, formatter) => current.Select(formatter.Format).ToList());
    }

    public void AddFormatter(IFormatter formatter)
    {
        Formatters.Add(formatter);
    }
}