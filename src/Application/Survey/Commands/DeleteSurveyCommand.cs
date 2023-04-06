using MediatR;

namespace Questionnaire.Application.Survey.Commands;

public record DeleteSurveyCommand(Guid Id) : IRequest;