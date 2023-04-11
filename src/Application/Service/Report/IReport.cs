using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Report;

public interface IReport
{
    public Task<string> GenerateReport(Survey survey,IEnumerable<Answer> answers, IEnumerable<Question> questions);
}