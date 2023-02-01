using Microsoft.Extensions.DependencyInjection;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Infrastructure.Persistence.InMemory;

namespace Questionnaire.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ILexicalization, Lexicalization>();
        return services;
    }
}