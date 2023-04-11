using Questionnaire.Application.Service.Rule;
using Questionnaire.Application.Tests.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Rule;

public class ContentRuleTests
{
    private readonly ITestOutputHelper _output;
    private readonly ContentRule _sut;

    public ContentRuleTests(ITestOutputHelper output)
    {
        _output = output;
        _sut = new ContentRule();
    }

    [Fact]
    public void Rule()
    {
        // Arrange
        var survey = Generator.GenerateSurvey();
        var score = new List<double>
        {
            2.1,
            1.3,
            3.5,
            2.0,
            4.1
        };
        var answers = survey.SurveyQuestions
            .Zip(score, (x, y) => new Answer(Guid.NewGuid(), y, x));

        const double expected = 1.7;
        const double expected2 = 4.1;
        const double expected3 = 1;
        const double expected4 = 1.3;
        // Act
        var p = _sut.Rule(answers);
        // Assert
        Assert.Equal(expected, p.Min.AverageScore);
        Assert.Equal(expected2, p.Max.AverageScore);
        Assert.Equal(expected3, p.Good.Count);
        Assert.Equal(expected3, p.Bad.Count);
        Assert.Equal(
            expected4,
            p.Min.Answer
                .OrderBy(a => a.Score)
                .Select(a => a.Score)
                .ToList()
                .First());
        _output.WriteLine(p.ToString());
    }
}