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
}