using MediatR;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.LecturerManagement.Commands;

public record AddLecturerCommand(string Name, LecturerTitle Title) : IRequest<LecturerResult>;