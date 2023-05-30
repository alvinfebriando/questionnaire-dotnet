using MediatR;

namespace Questionnaire.Application.Auth.Queries;

public record LoginQuery(string Email, string Password) : IRequest<AuthResult>;