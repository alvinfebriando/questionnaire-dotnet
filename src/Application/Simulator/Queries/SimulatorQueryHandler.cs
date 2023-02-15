using MediatR;
using Numpy;
using Python.Runtime;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Simulator.Queries;

public class SimulatorQueryHandler : IRequestHandler<SimulatorQuery, SimulatorResult>
{
    private readonly IWeightProvider _weightProvider;

    public SimulatorQueryHandler(IWeightProvider weightProvider)
    {
        _weightProvider = weightProvider;
    }

    public async Task<SimulatorResult> Handle(SimulatorQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var questionCount = request.DominantScores.Count;
        var weight = MapDominantScoreToWeight(request.DominantScores);
        var answers = await RandomScore(questionCount, request.RespondentCount, weight);

        return new SimulatorResult(answers);
    }

    private static async Task<int[][]> RandomScore(int questionCount,
        int respondentCount,
        double[][] weight)
    {
        await Task.CompletedTask;
        var answers = new int[questionCount][];

        using (Py.GIL())
        {
            for (var i = 0; i < questionCount; i++)
            {
                var result = np.random.choice(
                    new int[] { 1, 2, 3, 4, 5 },
                    new int[] { respondentCount },
                    p: weight[i]);
                answers[i] = result.GetData<int>();
            }
        }

        return answers;
    }

    private double[][] MapDominantScoreToWeight(IEnumerable<int> scores)
    {
        return scores.Select(s => _weightProvider.Weight[s]).ToArray();
    }
}