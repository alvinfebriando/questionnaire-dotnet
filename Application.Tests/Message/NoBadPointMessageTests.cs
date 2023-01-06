﻿using System.Globalization;
using Moq;
using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Application.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class NoBadPointMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly NoBadPointMessage _sut;

    public NoBadPointMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var answer1 = new Answer(3.1,
            new Question("title1", QuestionSection.TransparansiNilai, "advice1"));
        var answer2 = new Answer(3.1,
            new Question("title2", QuestionSection.TransparansiNilai, "advice2"));
        var answers = new List<Answer> { answer1, answer2 };
        var averagedAnswer = new AveragedAnswer(QuestionSection.TransparansiNilai, 3.1, answers);
        var dto = new PointDto("pak alvin", averagedAnswer);
        var lex = new Mock<ILexicalization>();
        lex.Setup(l => l.Search("nilai")).Returns("nilai");
        lex.Setup(l => l.Search("didapatkan")).Returns("didapatkan");
        lex.Setup(l => l.Search("tertinggi")).Returns("tertinggi");
        lex.Setup(l => l.Search("serta")).Returns("serta");
        lex.Setup(l => l.Search("meskipun demikian")).Returns("meskipun demikian");
        _sut = new NoBadPointMessage(dto, lex.Object);
    }

    [Fact]
    public void Lexicalization_NoArgument_ReturnEmbeddedString()
    {
        // Arrange
        var expected = _sut.Data.Answer.AverageScore;
        // Act
        var s = _sut.Lexicalization();
        // Assert
        Assert.Contains(expected.ToString(CultureInfo.CurrentCulture), s);
        _output.WriteLine(s);
    }

    [Fact]
    public void EmbedComplement_GoodOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("good");
        const string expected = "serta, ";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        _output.WriteLine(_sut.Complement[0]);
    }

    [Fact]
    public void EmbedComplement_NoGoodOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("no good");
        const string expected = "meskipun demikian, ";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
        _output.WriteLine(_sut.Complement[0]);
    }
}