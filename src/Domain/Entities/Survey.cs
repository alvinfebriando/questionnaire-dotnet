namespace Questionnaire.Domain.Entities;

public class Survey : BaseEntity
{
    public string Place { get; set; }
    public DateOnly Date { get; set; }
    public string Subject { get; set; }
    public Lecturer Lecturer { get; set; }
    public int QuestionCount { get; set; }
    public int AspectCount { get; set; }
    public ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    public ICollection<User> AnsweredBy { get; set; }
}