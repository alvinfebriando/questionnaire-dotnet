using MediatR;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Survey.Commands;

public record AddSurveyCommand(
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    int QuestionCount,
    int AspectCount,
    ICollection<Guid> QuestionId) : IRequest<Unit>;