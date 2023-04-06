using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.WebApi.Dto;

public record AddLecturerRequest(string Name, LecturerTitle Title);