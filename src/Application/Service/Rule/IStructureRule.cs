using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Rule;

public interface IStructureRule
{
    public Structure Rule(Point point);
}