namespace Questionnaire.Application.Dto;

public record OpeningDto(string Place, DateOnly Date, string Subject,
    string Respondent);