using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.LecturerManagement;

public record LecturerResult(Guid Id, string Name, LecturerTitle Title);
public record AllLecturerResult(IEnumerable<LecturerResult> Lecturers);