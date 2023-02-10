namespace Questionnaire.Application.Service.Dto;

public record OpeningDto(string Place, DateOnly Date, string Subject,
    string Respondent);