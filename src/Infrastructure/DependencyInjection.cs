using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Infrastructure.Persistence.InMemory;
using Questionnaire.Infrastructure.Persistence.Postgres;

namespace Questionnaire.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration config)
    {
        services.AddScoped<ILexicalization, Lexicalization>();
        services.AddScoped<IQuestionRepository, Persistence.Postgres.QuestionRepository>();
        services.AddScoped<IWeightProvider, WeightProvider>();
        services.AddScoped<ITemplateProvider, TemplateProvider>();

        services.AddDbContext<ApplicationDbContext>(
            options => options.UseNpgsql(config.GetConnectionString("Default")));
        return services;
    }
}