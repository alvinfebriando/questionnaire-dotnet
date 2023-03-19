using Questionnaire.WebApi.Common.JsonConverter;
using Questionnaire.WebApi.Mapping;

namespace Questionnaire.WebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMappings();
        services.AddCors(
            options =>
            {
                options.AddDefaultPolicy(policy => { policy.AllowAnyOrigin().AllowAnyHeader(); });
            });
        services.AddControllers()
            .AddJsonOptions(
                options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
                    options.JsonSerializerOptions.Converters.Add(new QuestionJsonConverter());
                });

        return services;
    }
}