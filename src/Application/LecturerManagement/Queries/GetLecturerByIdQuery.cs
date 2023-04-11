using MediatR;

namespace Questionnaire.Application.LecturerManagement.Queries;

public record GetLecturerByIdQuery(Guid id) : IRequest<LecturerResult>;