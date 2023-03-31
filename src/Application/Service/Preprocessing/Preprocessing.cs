using Questionnaire.Application.Data;
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

    public static IEnumerable<Answer> Convert(
        IEnumerable<Question> questions,
        IEnumerable<AnswerScore> answers)
    {
        var output = new List<Answer>();
        foreach (var answer in answers)
        {
            var sq = new SurveyQuestion
            {
                QuestionId = answer.QuestionId,
                Question = questions.First(q => q.Id == answer.QuestionId)
            };
            output.Add(new Answer(Guid.NewGuid(), answer.Score, sq));
        }

        return output;
    }
}