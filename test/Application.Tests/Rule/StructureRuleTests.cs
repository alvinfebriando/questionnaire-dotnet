using Questionnaire.Application.Service.Rule;
using Questionnaire.Application.Tests.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Rule;

public class StructureRuleTests
{
    private readonly ITestOutputHelper _output;
    private readonly StructureRule _sut;

    public StructureRuleTests(ITestOutputHelper output)
    {
        _output = output;
        _sut = new StructureRule();
    }

    [Fact]
    public void Rule_GoodEmptyBadEmpty_ReturnStructure()
    {
        // Arrange
        var p = new Point();

        const string expected = "opening";
        var expected2 = new List<string> { "score", "performance" };
        var expected3 = new List<string> { "no good", "no bad" };
        const string expected4 = "no advice";
        // Act
        var s = _sut.Rule(p);
        // Assert
        Assert.Equal(expected, s.Get(0));
        Assert.Contains(s.Get(1), expected2);
        Assert.Contains(s.Get(3), expected3);
        Assert.Equal(expected4, s.Get(5));

        _output.WriteLine(s.ToString());
    }

    [Fact]
    public void Rule_GoodEmptyBadNotEmpty_ReturnStructure()
    {
        // Arrange
        var p = new Point();
        var averagedAnswer = Generator.GenerateAveragedAnswer();
        p.Bad.Add(averagedAnswer);

        const string expected = "opening";
        var expected2 = new List<string> { "score", "performance" };
        var expected3 = new List<string> { "no good", "bad" };
        const string expected4 = "advice";
        // Act
        var s = _sut.Rule(p);
        // Assert
        Assert.Equal(expected, s.Get(0));
        Assert.Contains(s.Get(1), expected2);
        Assert.Contains(s.Get(3), expected3);
        Assert.Equal(expected4, s.Get(5));

        _output.WriteLine(s.ToString());
    }

    [Fact]
    public void Rule_GoodNotEmptyBadEmpty_ReturnStructure()
    {
        // Arrange
        var p = new Point();
        var averagedAnswer = Generator.GenerateAveragedAnswer();
        p.Good.Add(averagedAnswer);

        const string expected = "opening";
        var expected2 = new List<string> { "score", "performance" };
        var expected3 = new List<string> { "no bad", "good" };
        const string expected4 = "no advice";
        // Act
        var s = _sut.Rule(p);
        // Assert
        Assert.Equal(expected, s.Get(0));
        Assert.Contains(s.Get(1), expected2);
        Assert.Contains(s.Get(3), expected3);
        Assert.Equal(expected4, s.Get(5));

        _output.WriteLine(s.ToString());
    }

    [Fact]
    public void Rule_GoodNotEmptyBadNotEmpty_ReturnStructure()
    {
        // Arrange
        var p = new Point();
        var averagedAnswer1 = Generator.GenerateAveragedAnswer();
        var averagedAnswer2 = Generator.GenerateAveragedAnswer();
        p.Good.Add(averagedAnswer1);
        p.Bad.Add(averagedAnswer2);

        const string expected = "opening";
        var expected2 = new List<string> { "score", "performance" };
        var expected3 = new List<string> { "bad", "good" };
        const string expected4 = "advice";
        // Act
        var s = _sut.Rule(p);
        // Assert
        Assert.Equal(expected, s.Get(0));
        Assert.Contains(s.Get(1), expected2);
        Assert.Contains(s.Get(3), expected3);
        Assert.Equal(expected4, s.Get(5));

        _output.WriteLine(s.ToString());
    }
}