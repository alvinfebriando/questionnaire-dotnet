namespace Questionnaire.Application.Common.Interfaces;

public interface IWeightProvider
{
    public Dictionary<int, double[]> Weight { get; set; }
}