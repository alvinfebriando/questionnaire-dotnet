using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Common.Interfaces;

public interface IQuestionProvider
{
    public IList<Question> Questions { get; set; }
}