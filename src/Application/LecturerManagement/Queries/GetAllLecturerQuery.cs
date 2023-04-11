using MediatR;

namespace Questionnaire.Application.LecturerManagement.Queries;

public record GetAllLecturerQuery() : IRequest<AllLecturerResult>;