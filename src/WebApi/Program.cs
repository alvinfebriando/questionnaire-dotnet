using Numpy;
using Python.Runtime;
using Questionnaire.Application;
using Questionnaire.Infrastructure;
using Questionnaire.WebApi;

np.arange(1);
PythonEngine.BeginAllowThreads();

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddInfrastructure(builder.Configuration);
    builder.Services.AddApplication();
    builder.Services.AddPresentation(builder.Configuration);
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseCors();
    // app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}