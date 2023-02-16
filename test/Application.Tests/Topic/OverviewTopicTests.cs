using Questionnaire.Application.Service.Message;
using Questionnaire.Application.Service.Topic;
using Questionnaire.Domain.Entities;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Topic;

public class OverviewTopicTests
{
    private readonly ITestOutputHelper _output;
    private readonly OverviewTopic _sut;

    public OverviewTopicTests(ITestOutputHelper output)
    {
        _output = output;
        var date = new DateOnly(2022, 12, 28);
        var point = new Point();
        var content = new Content(
            "place",
            date,
            "subject",
            "respondent",
            "lecturer",
            3.5,
            0,
            0,
            point);
        var structure = new Structure();
        var lex = Lexicalization.Create();
        _sut = new OverviewTopic(content, structure, lex);
    }

    [Fact]
    public void Order_FirstStructureScore_ReturnListOfMessages()
    {
        // Arrange
        _sut.Structure = new Structure();
        _sut.Structure.Add("");
        _sut.Structure.Add("score");
        // Act
        var s = _sut.Order();
        // Assert
        Assert.IsType<AverageScoreMessage>(s[0]);
        Assert.IsType<PerformanceStatusMessage>(s[1]);
    }

    [Fact]
    public void Order_FirstStructurePerformance_ReturnListOfMessages()
    {
        // Arrange
        _sut.Structure = new Structure();
        _sut.Structure.Add("");
        _sut.Structure.Add("performance");
        const int expected = 2;
        // Act
        var s = _sut.Order();
        // Assert
        Assert.Equal(expected, s.Count);
        Assert.IsType<AverageScoreMessage>(s[1]);
        Assert.IsType<PerformanceStatusMessage>(s[0]);
    }
}