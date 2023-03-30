using Questionnaire.Application.Service.DocumentPlanning;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Report;

public class Report : IReport
{
    public async Task<string> GenerateReport(
        Domain.Entities.Survey survey,
        IEnumerable<Answer> answers,
        IEnumerable<Question> questions)
    {
        return "DONE";
    }
}