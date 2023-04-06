namespace Questionnaire.WebApi.Dto;

public record LecturerResponse(Guid Id, string Name, string Title);
public record AllLecturerResponse(IEnumerable<LecturerResponse> Lecturers);