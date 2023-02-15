using Numpy;
using Python.Runtime;
using Questionnaire.Application;
using Questionnaire.Infrastructure;
using Questionnaire.WebApi;

np.arange(1);
PythonEngine.BeginAllowThreads();

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddInfrastructure();
    builder.Services.AddApplication();
    builder.Services.AddPresentation();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseCors();
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}