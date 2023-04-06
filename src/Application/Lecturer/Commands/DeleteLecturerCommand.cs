using MediatR;

namespace Questionnaire.Application.Lecturer.Commands;

public record DeleteLecturerCommand(Guid id) : IRequest;
