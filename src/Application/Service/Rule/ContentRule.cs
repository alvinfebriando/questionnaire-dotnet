using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Rule;

public class ContentRule : IContentRule
{
    public Point Rule(IEnumerable<Answer> answers)
    {
        var averagedAnswers = answers.GroupBy(a => a.SurveyQuestion.Question.Section)
            .Select(
                answer => new AveragedAnswer(
                    answer.Key,
                    Math.Round(answer.Select(a => a.Score).Average(), 2),
                    answer.Select(a => a))
            )
            .OrderByDescending(q => q.AverageScore)
            .ToList();
        var output = new Point(averagedAnswers.First(), averagedAnswers.Last());

        foreach (var a in averagedAnswers)
            switch (a.AverageScore)
            {
                case <= 2:
                    output.Bad.Add(a);
                    break;
                case >= 4:
                    output.Good.Add(a);
                    break;
            }

        return output;
    }
}