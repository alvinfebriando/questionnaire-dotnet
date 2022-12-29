using Questionnaire.Application.Message;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Topic;

public abstract class BaseTopic<T> where T : class
{
    protected BaseTopic(Content content, Structure structure)
    {
        Content = content;
        Structure = structure;
    }

    public Content Content { get; set; }
    public Structure Structure { get; set; }
    public abstract IList<BaseMessage<T>> Order();
    public abstract IList<string> Aggregate();
}