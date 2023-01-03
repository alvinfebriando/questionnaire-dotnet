using Questionnaire.Application.Topic;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.MicroPlanning;

public interface IMicroPlanning
{
    public Content Content { get; set; }
    public Structure Structure { get; set; }
    public IEnumerable<BaseTopic> Create();
}