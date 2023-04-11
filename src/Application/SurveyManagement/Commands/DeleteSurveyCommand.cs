using MediatR;

namespace Questionnaire.Application.SurveyManagement.Commands;

public record DeleteSurveyCommand(Guid Id) : IRequest;