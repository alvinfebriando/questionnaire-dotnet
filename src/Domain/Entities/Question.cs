namespace Questionnaire.Domain.Entities;

public class Question : BaseEntity
{
    public Question()
    {
        
    }
    public Question(Guid id, string title, QuestionSection section, string advice)
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
    public string Title { get; set; }
    public QuestionSection Section { get; set; }
    public string Advice { get; set; }
}