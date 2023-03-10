using System.Globalization;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class GoodPointMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly GoodPointMessage _sut;

    public GoodPointMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var answer1 = new Answer(
            4.1,
            new Question("title1", QuestionSection.KedisiplinanWaktu, "advice1"));
        var answer2 = new Answer(
            4.1,
            new Question("title2", QuestionSection.KedisiplinanWaktu, "advice2"));
        var answers = new List<Answer> { answer1, answer2 };
        var averagedAnswer = new AveragedAnswer(QuestionSection.KedisiplinanWaktu, 4.1, answers);
        var dto = new PointDto("pak alvin", averagedAnswer);
        var lex = Lexicalization.Create();
        _sut = new GoodPointMessage(dto, lex);
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
    public void Lexicalization_2Answer_ReturnEmbeddedString()
    {
        // Arrange
        var answer1 = new Answer(
            4.1,
            new Question("title1", QuestionSection.KedisiplinanWaktu, "advice1"));
        var answer2 = new Answer(
            4.1,
            new Question("title2", QuestionSection.KedisiplinanWaktu, "advice2"));
        var answers = new List<Answer> { answer1, answer2 };
        var averagedAnswer1 = new AveragedAnswer(QuestionSection.TransparansiNilai, 4.1, answers);

        var answer3 = new Answer(
            4.1,
            new Question("title1", QuestionSection.TransparansiNilai, "advice3"));
        var answer4 = new Answer(
            4.1,
            new Question("title2", QuestionSection.TransparansiNilai, "advice4"));
        var answers2 = new List<Answer> { answer3, answer4 };
        var averagedAnswer2 = new AveragedAnswer(QuestionSection.TransparansiNilai, 4.1, answers2);

        var expected = averagedAnswer2.AverageScore;

        // Act
        var s = _sut.EntitySlotting(new List<AveragedAnswer> { averagedAnswer1, averagedAnswer2 });

        // Assert
        Assert.Contains(expected.ToString(CultureInfo.CurrentCulture), s);
        _output.WriteLine(s);
    }

    [Fact]
    public void Lexicalization_MoreThan3Answer_ReturnEmbeddedString()
    {
        // Arrange
        var answer1 = new Answer(
            4.1,
            new Question("title1", QuestionSection.PenggunaanElearning, "advice1"));
        var answer2 = new Answer(
            4.1,
            new Question("title2", QuestionSection.PenggunaanElearning, "advice2"));
        var answers = new List<Answer> { answer1, answer2 };
        var averagedAnswer1 = new AveragedAnswer(QuestionSection.PenggunaanElearning, 4.1, answers);
        var expected = averagedAnswer1.AverageScore;

        // Act
        var s = _sut.EntitySlotting(
            new List<AveragedAnswer> { averagedAnswer1, averagedAnswer1, averagedAnswer1 });

        // Assert
        Assert.Contains(expected.ToString(CultureInfo.CurrentCulture), s);
        _output.WriteLine(s);
    }

    [Fact]
    public void EmbedComplement_BadOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("bad");
        const string expected = "meskipun demikian, ";
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
        const string expected = "serta, ";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        _output.WriteLine(_sut.Complement[0]);
    }
}