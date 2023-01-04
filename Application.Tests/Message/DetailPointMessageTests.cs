using Moq;
using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Application.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class DetailPointMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly DetailPointMessage _sut;

    public DetailPointMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var answer1 = new Answer(4.1,
            new Question("title1", QuestionSection.KedisiplinanWaktu, "advice1"));
        var answer2 = new Answer(4.1,
            new Question("title2", QuestionSection.KedisiplinanWaktu, "advice2"));
        var answers = new List<Answer> { answer1, answer2 };
        var averagedAnswer = new AveragedAnswer(QuestionSection.KedisiplinanWaktu, 4.1, answers);
        var dto = new PointDto("pak alvin", averagedAnswer);
        var lex = new Mock<ILexicalization>();
        lex.Setup(l => l.Search("tertinggi")).Returns("tertinggi");
        lex.Setup(l => l.Search("terendah")).Returns("terendah");
        _sut = new DetailPointMessage(dto, lex.Object);
    }

    [Fact]
    public void Lexicalization_NoArgument_ReturnEmbeddedString()
    {
        // Arrange
        var expected = _sut.Data.Answer.Answer.First().Question.Title;
        // Act
        var s = _sut.Lexicalization();
        // Assert
        Assert.Contains(expected, s);
        _output.WriteLine(s);
    }

    [Fact]
    public void EmbedComplement_MaxOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("max");
        const string expected = "tertinggi";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        _output.WriteLine(_sut.Complement[0]);
    }
    [Fact]
    public void EmbedComplement_MinOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("min");
        const string expected = "terendah";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        _output.WriteLine(_sut.Complement[0]);
    }
}