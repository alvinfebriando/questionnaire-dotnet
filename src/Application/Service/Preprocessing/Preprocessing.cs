using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Preprocessing;

public static class Preprocessing
{
    public static double CalculateAverageScore(IEnumerable<Answer> answers)
    {
        var enumerable = answers.ToList();
        return Math.Round(enumerable.Select(x => x.Score).Average(), 2);
    }

    public static IEnumerable<Answer> Convert(
        IQuestionRepository questionRepository,
        IEnumerable<double> answers)
    {
        return answers
            .Select((score, index) => new Answer(score, questionRepository.Questions[index]))
            .ToList();
    }
}