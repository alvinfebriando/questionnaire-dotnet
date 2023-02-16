using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Questionnaire.Application.Service.DocumentPlanning;
using Questionnaire.Application.Service.MicroPlanning;
using Questionnaire.Application.Service.Realization;
using Questionnaire.Application.Service.Rule;

namespace Questionnaire.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddScoped<IContentRule, ContentRule>();
        services.AddScoped<IStructureRule, StructureRule>();
        services.AddScoped<IDocumentPlanning, DocumentPlanning>();
        services.AddScoped<IMicroPlanning, MicroPlanning>();
        services.AddScoped<IRealization, Realization>();
        return services;
    }
}