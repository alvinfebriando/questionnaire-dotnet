using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

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
        IEnumerable<AnswerScore> answers)
    {
        var output = new List<Answer>();
        foreach (var answer in answers)
        {
            // output.Add(new Answer(Guid.NewGuid(), answer.Score, await questionRepository.GetById(answer.QuestionId)));
        }

        return output;
    }
}