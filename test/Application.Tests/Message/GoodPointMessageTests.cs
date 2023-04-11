﻿using System.Globalization;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using SharedKernel;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class GoodPointMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly GoodPointMessage _sut;

    public GoodPointMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var averagedAnswer = Generator.GenerateAveragedAnswer();
        var dto = new PointDto("pak alvin", averagedAnswer);
        var lex = Lexicalization.Create();
        var tp = TemplateProvider.Create();
        _sut = new GoodPointMessage(dto, lex, tp);
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
        var averagedAnswer1 = Generator.GenerateAveragedAnswer();
        var averagedAnswer2 = Generator.GenerateAveragedAnswer();
        
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
        var averagedAnswer1 = Generator.GenerateAveragedAnswer();
        var averagedAnswer2 = Generator.GenerateAveragedAnswer();
        var averagedAnswer3 = Generator.GenerateAveragedAnswer();
        var expected = averagedAnswer1.AverageScore;

        // Act
        var s = _sut.EntitySlotting(
            new List<AveragedAnswer> { averagedAnswer1, averagedAnswer2, averagedAnswer3 });

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