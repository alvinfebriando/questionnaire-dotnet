using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Questionnaire.Application.Service.Rule;

namespace Questionnaire.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddScoped<IContentRule, ContentRule>();
        services.AddScoped<IStructureRule, StructureRule>();
        return services;
    }
}