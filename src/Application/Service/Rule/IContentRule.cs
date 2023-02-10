using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Rule;

public interface IContentRule
{
    public Point Rule(IEnumerable<Answer> answers);
}