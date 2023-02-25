using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Topic;

public abstract class GenericTopic<T> : BaseTopic where T : class
{
    protected GenericTopic(Content content, Structure structure) : base(content, structure)
    {
    }

    public abstract IList<BaseMessage<T>> Sort();
}