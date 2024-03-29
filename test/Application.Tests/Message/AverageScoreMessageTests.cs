﻿using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.ValueObjects;
using SharedKernel;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class AverageScoreMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly AverageScoreMessage _sut;

    public AverageScoreMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var overviewDto = new OverviewDto(
            "pak alvin",
            4.5,
            13,
            6);
        var lex = Lexicalization.Create();
        var tp = TemplateProvider.Create();
        _sut = new AverageScoreMessage(overviewDto, lex, tp);
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