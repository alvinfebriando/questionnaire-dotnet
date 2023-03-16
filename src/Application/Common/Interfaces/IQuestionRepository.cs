using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Common.Interfaces;

public interface IQuestionRepository
{
    public IList<Question> Questions { get; set; }
}