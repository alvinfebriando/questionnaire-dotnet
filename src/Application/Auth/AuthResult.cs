using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Auth;

public record AuthResult(User User, string Token);