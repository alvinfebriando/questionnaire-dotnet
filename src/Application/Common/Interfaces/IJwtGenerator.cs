using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Common.Interfaces;

public interface IJwtGenerator
{
    public string GenerateToken(User user);
}