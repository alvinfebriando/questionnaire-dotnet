using Questionnaire.Domain.Entities;

namespace Questionnaire.WebApi.Dto;

public record AllSurveyResponse(IEnumerable<SurveyResponse> Surveys);
public record SurveyResponse(
    Guid Id,
    string Place,
    DateOnly Date,
    string Subject,
    Lecturer Lecturer,
    int QuestionCount,
    int AspectCount,
    ICollection<QuestionResponse> Questions);