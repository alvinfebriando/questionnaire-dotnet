namespace Questionnaire.Domain.Entities;

public class Answer : BaseEntity
{
    public Answer(Guid id, double score, Question question)
    {
        Score = score;
        Question = question;
        Id = id;
    }

    public Answer()
    {
        
    }

    public Question Question { get; set; }
    public double Score { get; set; }
}