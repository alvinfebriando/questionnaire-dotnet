namespace Questionnaire.Domain.Entities;

public class SurveyQuestion
{
    public Guid SurveyId { get; set; }
    public Survey Survey { get; set; }
    public Guid QuestionId { get; set; }
    public Question Question { get; set; }
}