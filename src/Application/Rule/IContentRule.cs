using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Rule;

public interface IContentRule
{
    public Point Rule(IEnumerable<Answer> answers);
}