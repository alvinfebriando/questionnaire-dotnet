using Questionnaire.Domain.Entities;

namespace Questionnaire.WebApi.Dto;

public record SurveyResponse(
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    int QuestionCount,
    int AspectCount,
    ICollection<Question> Questions);