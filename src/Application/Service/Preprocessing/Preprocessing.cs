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

    public static IEnumerable<Answer> AverageOfEachQuestion(
        IEnumerable<Answer> answers,
        IEnumerable<Question> questions)
    {
        var groupAnswerByQuestion = answers
            .GroupBy(a => a.SurveyQuestion.QuestionId)
            .Select(
                g => new { QuestionId = g.Key, Score = Math.Round(g.Average(a => a.Score), 2) });
        var averagedScore = groupAnswerByQuestion
            .Select(g => new AnswerScore(g.QuestionId, g.Score))
            .ToList();
        return (from score in averagedScore
            let sq = new SurveyQuestion()
            {
                QuestionId = score.QuestionId,
                Question = questions.First(q => q.Id == score.QuestionId)
            }
            select new Answer { Score = score.Score, SurveyQuestion = sq }).ToList();
    }
}