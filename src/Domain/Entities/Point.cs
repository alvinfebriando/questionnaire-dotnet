using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Domain.Entities;

public class Point
{
    public AveragedAnswer Max { get; set; }
    public AveragedAnswer Min { get; set; }
    public IList<AveragedAnswer> Good { get; set; } = new List<AveragedAnswer>();
    public IList<AveragedAnswer> Bad { get; set; } = new List<AveragedAnswer>();
}