using Questionnaire.Application.Service.Topic;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.MicroPlanning;

public interface IMicroPlanning
{
    public Content Content { get; set; }
    public Structure Structure { get; set; }
    public IEnumerable<BaseTopic> Create();
    public void Init(Content content, Structure structure);
}