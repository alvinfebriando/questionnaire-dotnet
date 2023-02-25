using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public interface IMultiEntitySlottingMessage
{
    public string EntitySlotting(IList<AveragedAnswer> messages);
}