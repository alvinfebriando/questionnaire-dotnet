namespace Questionnaire.WebApi.Dto;

public record ReportRequest(
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    double Score,
    int QuestionCount,
    int AspectCount,
    List<AnswerScore> Answers);
    
    public record AnswerScore(Guid QuestionId, double Score);