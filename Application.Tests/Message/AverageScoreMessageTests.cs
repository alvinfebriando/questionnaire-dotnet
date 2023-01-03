using Moq;
using Questionnaire.Application;
using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Application.Message;
using Questionnaire.Domain.ValueObjects;
using Xunit.Abstractions;

namespace Application.Tests.Message;

public class AverageScoreMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly AverageScoreMessage _sut;

    public AverageScoreMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var overviewDto = new OverviewDto("pak alvin",4.5);
        var lex = new Mock<ILexicalization>();
        _sut = new AverageScoreMessage(overviewDto,lex.Object);
    }

    [Fact]
    public void Lexicalization_NoArgument_ReturnEmbeddedString()
    {
        // Arrange
        var expected = _sut.Data.Lecturer;
        // Act
        var s = _sut.Lexicalization();
        // Assert
        Assert.Contains(expected, s);
    }

    [Fact]
    public void EmbedComplement_FirstOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("first");
        const string expected = "berdasarkan jawaban kuesioner, ";
        var expected2 = _sut.Data.Lecturer;
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        Assert.Equal(expected2, _sut.Complement[1]);
    }
    
    [Fact]
    public void EmbedComplement_SecondOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("second");
        const string expected = "";
        const string expected2 = "beliau";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        Assert.Equal(expected2, _sut.Complement[1]);
    }
}