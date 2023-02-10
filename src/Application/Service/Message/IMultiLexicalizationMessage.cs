using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public interface IMultiLexicalizationMessage
{
    public string Lexicalization(IList<AveragedAnswer> messages);
}