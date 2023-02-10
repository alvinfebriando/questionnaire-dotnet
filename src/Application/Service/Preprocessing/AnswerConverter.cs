using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Preprocessing;

public static class AnswerConverter
{
    public static IEnumerable<Answer> Convert(IQuestionProvider questionProvider,
        IEnumerable<double> answers)
    {
        return answers
            .Select((score, index) => new Answer(score, questionProvider.Questions[index]))
            .ToList();
    }
}