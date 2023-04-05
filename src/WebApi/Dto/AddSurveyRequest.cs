using Questionnaire.Domain.Entities;

namespace Questionnaire.WebApi.Dto;

public record AddSurveyRequest(
    string Place,
    DateOnly Date,
    string Subject,
    string Lecturer,
    int QuestionCount,
    int AspectCount,
    IEnumerable<Guid> QuestionId);