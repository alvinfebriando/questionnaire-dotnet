using MediatR;

namespace Questionnaire.Application.Lecturer.Queries;

public record GetAllLecturerQuery() : IRequest<AllLecturerResult>;