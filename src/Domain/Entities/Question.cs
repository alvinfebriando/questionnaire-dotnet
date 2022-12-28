namespace Questionnaire.Domain.Entities;

public class Question
{
    public Question(string title, QuestionSection section, string advice)
    {
        Title = title;
        Section = section;
        Advice = advice;
    }

    public Guid Id { get; } = Guid.NewGuid();
    public string Title { get; set; }
    public QuestionSection Section { get; set; }
    public string Advice { get; set; }
}