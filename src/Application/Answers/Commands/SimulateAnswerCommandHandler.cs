using MediatR;
using Numpy;
using Python.Runtime;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Data;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Answers.Commands;

public class SimulateAnswerCommandHandler : IRequestHandler<SimulateAnswerCommand, Unit>
{
    private readonly IApplicationDbContext _context;
    private readonly IWeightProvider _weightProvider;

    public SimulateAnswerCommandHandler(
        IApplicationDbContext context,
        IWeightProvider weightProvider)
    {
        _context = context;
        _weightProvider = weightProvider;
    }

    public async Task<Unit> Handle(
        SimulateAnswerCommand request,
        CancellationToken cancellationToken)
    {
        var surveyId = request.Answers.First().SurveyId;
        var scores = request.Answers.Select(a => a.Score).ToList();
        var weight = MapDominantScoreToWeight(scores.Select(Convert.ToInt32));
        var randomAnswer = RandomScore(scores.Count, request.N, weight);

        var merged = randomAnswer.Zip(
            request.Answers,
            (x, y) => (new { y.QuestionId, Scores = x }));

        foreach (var m in merged)
        {
            BulkInsert(surveyId, m.QuestionId, m.Scores);
        }

        await _context.SaveChangesAsync(cancellationToken);


        return Unit.Value;
    }

    private void BulkInsert(Guid surveyId, Guid questionId, IEnumerable<int> scores)
    {
        var surveyQuestion = new SurveyQuestion { SurveyId = surveyId, QuestionId = questionId };

        _context.SurveyQuestions.Attach(surveyQuestion);
        foreach (var score in scores)
        {
            var a = new Answer { Score = score, SurveyQuestion = surveyQuestion };
            _context.Answers.Add(a);
        }
    }

    private static int[][] RandomScore(
        int questionCount,
        int respondentCount,
        double[][] weight)
    {
        var answers = new int[questionCount][];

        using (Py.GIL())
        {
            for (var i = 0; i < questionCount; i++)
            {
                var result = np.random.choice(
                    new[] { 1, 2, 3, 4, 5 },
                    new[] { respondentCount },
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

    private static int[][] Transpose(int[][] scores)
    {
        var rows = scores.Length;
        var cols = scores[0].Length;
        int[][] result = new int[cols][];
        for (var i = 0; i < cols; i++)
        {
            result[i] = new int[rows];
            for (var j = 0; j < rows; j++)
            {
                result[i][j] = scores[j][i];
            }
        }

        return result;
    }
}