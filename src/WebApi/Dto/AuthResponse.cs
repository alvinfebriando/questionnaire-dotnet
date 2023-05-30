namespace Questionnaire.WebApi.Dto;

public record AuthResponse(Guid Id, string Name, string Email, string Token);