namespace Questionnaire.Domain.Entities;

public class Content
{
    public Content(string place, DateOnly date, string subject, string respondent, string lecturer,
        double score, int questionCount, int aspectCount, Point point)
    {
        Place = place;
        Date = date;
        Subject = subject;
        Respondent = respondent;
        Lecturer = lecturer;
        AverageScore = score;
        QuestionCount = questionCount;
        AspectCount = aspectCount;
        Point = point;
    }

    public string Place { get; set; }
    public DateOnly Date { get; set; }
    public string Subject { get; set; }
    public string Respondent { get; set; }
    public string Lecturer { get; set; }
    public double AverageScore { get; set; }
    public int QuestionCount { get; set; }
    public int AspectCount { get; set; }
    public Point Point { get; set; }
}