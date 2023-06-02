namespace Questionnaire.Domain.Entities;

public class AnswerUser
{
    public Guid AnswerId { get; set; }
    public Answer Answer { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}