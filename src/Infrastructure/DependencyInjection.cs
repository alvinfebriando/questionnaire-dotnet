using Microsoft.Extensions.DependencyInjection;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Infrastructure.Persistence.InMemory;

namespace Questionnaire.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ILexicalization, Lexicalization>();
        services.AddScoped<IQuestionRepository, QuestionRepository>();
        services.AddScoped<IWeightProvider, WeightProvider>();
        services.AddScoped<ITemplateProvider, TemplateProvider>();
        return services;
    }
}