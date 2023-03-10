using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class NoGoodPointMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly NoGoodPointMessage _sut;

    public NoGoodPointMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var answer1 = new Answer(
            3.1,
            new Question("title1", QuestionSection.TransparansiNilai, "advice1"));
        var answer2 = new Answer(
            3.1,
            new Question("title2", QuestionSection.TransparansiNilai, "advice2"));
        var answers = new List<Answer> { answer1, answer2 };
        var averagedAnswer = new AveragedAnswer(QuestionSection.TransparansiNilai, 3.1, answers);
        var dto = new PointDto("pak alvin", averagedAnswer);
        var lex = Lexicalization.Create();
        _sut = new NoGoodPointMessage(dto, lex);
    }

    [Fact]
    public void Lexicalization_NoArgument_ReturnEmbeddedString()
    {
        // Arrange
        var expected = _sut.Data.Lecturer;
        // Act
        var s = _sut.EntitySlotting();
        // Assert
        Assert.Contains(expected, s);
        _output.WriteLine(s);
    }

    [Fact]
    public void EmbedComplement_BadOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("bad");
        const string expected = "serta, ";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        _output.WriteLine(_sut.Complement[0]);
    }

    [Fact]
    public void EmbedComplement_NoBadOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("no bad");
        const string expected = "namun, ";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        _output.WriteLine(_sut.Complement[0]);
    }
}