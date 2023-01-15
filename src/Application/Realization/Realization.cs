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
            IList<string> sentences;
            if (topic.GetType() == typeof(PointTopic))
            {
                sentences = topic.Aggregate();
                sentences = sentences.Select(s => $"{s} ").ToList();
                sentences[^3] = $"{sentences[^3]}\n";
                sentences[^2] = $"{sentences[^2].Trim()}\n";
                sentences[^1] = $"{sentences[^1]}\n";
            }
            else
            {
                sentences = topic.Aggregate();
                sentences = sentences.Select(s => $"{s} ").ToList();
                sentences[^1] += "\n";
            }


            output.AddRange(sentences);
        }

        foreach (var formatter in Formatters)
        {
            output = output.Select(s => formatter.Format(s)).ToList();
        }

        return output;
    }

    public void AddFormatter(IFormatter formatter)
    {
        Formatters.Add(formatter);
    }
}