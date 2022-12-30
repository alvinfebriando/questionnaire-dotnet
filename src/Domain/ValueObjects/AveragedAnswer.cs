using Questionnaire.Domain.Entities;

namespace Questionnaire.Domain.ValueObjects;

public class AveragedAnswer
{
    public AveragedAnswer(QuestionSection section, double averageScore, IEnumerable<Answer> answer)
    {
        Section = section;
        AverageScore = averageScore;
        Answer = answer;
    }

    public QuestionSection Section { get; set; }
    public double AverageScore { get; set; }
    public IEnumerable<Answer> Answer { get; set; }
}