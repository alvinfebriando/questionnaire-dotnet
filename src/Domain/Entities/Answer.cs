namespace Questionnaire.Domain.Entities;

public class Answer
{
    public Question Question { get; set; }
    public double Score { get; set; }

    public Answer(double score, Question question)
    {
        Score = score;
        Question = question;
    }
}