using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Questionnaire.WebApi.Common.JsonConverter;
using Questionnaire.WebApi.Mapping;

namespace Questionnaire.WebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(
        this IServiceCollection services,
        IConfiguration config)
    {
        services.AddMappings();
        services.AddCors(
            options =>
            {
                options.AddDefaultPolicy(
                    policy => { policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
            });
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(
                options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = config["JwtSettings:Issuer"],
                        ValidAudience = config["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(config["JwtSettings:Key"]))
                    };
                });
        services.AddAuthorization(
            options =>
            {
                options.AddPolicy(
                    "AdminOnly",
                    policy => { policy.RequireRole("Admin"); });
            });
        services.AddControllers()
            .AddJsonOptions(
                options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
                    options.JsonSerializerOptions.Converters.Add(new QuestionJsonConverter());
                    options.JsonSerializerOptions.Converters.Add(new LecturerJsonConverter());
                });
        return services;
    }
}