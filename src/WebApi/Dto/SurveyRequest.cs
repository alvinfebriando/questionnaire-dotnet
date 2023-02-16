namespace Questionnaire.WebApi.Dto;

public record SurveyRequest(
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    double Score,
    int QuestionCount,
    int AspectCount,
    List<double> Answers);