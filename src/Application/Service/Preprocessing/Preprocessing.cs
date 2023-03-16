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

    public static async Task<IEnumerable<Answer>> Convert(
        IQuestionRepository questionRepository,
        IEnumerable<double> answers)
    {
        var question = await questionRepository.GetById(Guid.Empty);
        return answers
            .Select((score, index) => new Answer(Guid.NewGuid(), score, question))
            .ToList();
    }
}