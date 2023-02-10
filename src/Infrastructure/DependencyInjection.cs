using Microsoft.Extensions.DependencyInjection;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Infrastructure.Persistence.InMemory;

namespace Questionnaire.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ILexicalization, Lexicalization>();
        services.AddScoped<IQuestionProvider, QuestionProvider>();
        return services;
    }
}