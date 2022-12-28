namespace Questionnaire.Domain.Entities;

public class Content
{
    public string Place { get; set; }
    public DateOnly Date { get; set; }
    public string Subject { get; set; }
    public string Respondent { get; set; }
    public string Lecturer { get; set; }
    public double AverageScore { get; set; }

    public Content(string place, DateOnly date, string subject, string respondent, string lecturer,
        double score)
    {
        Place = place;
        Date = date;
        Subject = subject;
        Respondent = respondent;
        Lecturer = lecturer;
        AverageScore = score;
    }
}