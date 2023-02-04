using Questionnaire.Application;
using Questionnaire.Infrastructure;
using Questionnaire.WebApi;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers().AddJsonOptions(options=>{options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());});
    builder.Services.AddInfrastructure();
    builder.Services.AddApplication();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}