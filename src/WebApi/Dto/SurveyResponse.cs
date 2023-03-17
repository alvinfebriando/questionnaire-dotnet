using Questionnaire.Domain.Entities;

namespace Questionnaire.WebApi.Dto;

public record SurveyResponse(
    Guid Id,
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    int QuestionCount,
    int AspectCount,
    ICollection<Question> Questions);