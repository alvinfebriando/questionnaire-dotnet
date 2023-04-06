using MediatR;

namespace Questionnaire.Application.Lecturer.Queries;

public record GetLecturerByIdQuery(Guid id) : IRequest<LecturerResult>;