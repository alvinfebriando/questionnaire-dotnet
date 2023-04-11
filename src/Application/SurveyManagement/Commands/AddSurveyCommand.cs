using MediatR;

namespace Questionnaire.Application.SurveyManagement.Commands;

public record AddSurveyCommand(
    string Place,
    DateOnly Date,
    string Subject,
    Guid Lecturer,
    int QuestionCount,
    int AspectCount,
    ICollection<Guid> QuestionId) : IRequest<SurveyResult>;