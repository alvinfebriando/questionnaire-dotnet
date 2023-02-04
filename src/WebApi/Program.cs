using Questionnaire.Application;
using Questionnaire.Infrastructure;
using Questionnaire.WebApi;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddInfrastructure();
    builder.Services.AddApplication();
    builder.Services.AddPresentation();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}