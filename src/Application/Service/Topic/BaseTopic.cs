using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Topic;

public abstract class BaseTopic
{
    protected BaseTopic(Content content, Structure structure)
    {
        Content = content;
        Structure = structure;
    }

    public Content Content { get; set; }
    public Structure Structure { get; set; }
    public abstract IList<Aggregated> Aggregate();

    public IEnumerable<BleuScoreContainer> CalculateBleuScore()
    {
        var aggregates = Aggregate();
        var bleu = new BLEU.BleuScore();
        var output = aggregates.Select(
            a => new BleuScoreContainer(
                a.Template,
                a.Result,
                bleu.RoundedScore(new List<string> { a.Template }, a.Result)));
        return output;
    }
}