using MediatR;

namespace Questionnaire.Application.LecturerManagement.Commands;

public record DeleteLecturerCommand(Guid id) : IRequest;
