using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Message;

public interface IComplemented
{
    public IList<string> Complement { get; set; }
    public void EmbedComplement(Option option);
}