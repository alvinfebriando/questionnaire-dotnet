namespace Questionnaire.Domain.Entities;

public class Question
{
    public Question(int id, string title, QuestionSection section, string advice)
    {
        Id = id;
        Title = title;
        Section = section;
        Advice = advice;
    }

    public Question(string title, QuestionSection section, string advice)
    {
        Title = title;
        Section = section;
        Advice = advice;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public QuestionSection Section { get; set; }
    public string Advice { get; set; }
}