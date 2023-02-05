using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Message;

public interface IMultiLexicalizationMessage
{
    public string Lexicalization(IList<AveragedAnswer> messages);
}