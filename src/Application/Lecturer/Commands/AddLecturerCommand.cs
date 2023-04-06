using MediatR;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Lecturer.Commands;

public record AddLecturerCommand(string Name, LecturerTitle Title) : IRequest<LecturerResult>;