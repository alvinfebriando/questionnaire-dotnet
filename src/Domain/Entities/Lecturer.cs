using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Domain.Entities;

public record Lecturer(Guid Id, string Name, LecturerTitle Title);
