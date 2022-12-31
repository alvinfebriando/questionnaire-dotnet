using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Rule;

public interface IStructureRule
{
    public Structure Rule(Point point);
}