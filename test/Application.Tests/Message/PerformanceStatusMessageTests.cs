﻿using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.ValueObjects;
using SharedKernel;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class PerformanceStatusMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly PerformanceStatusMessage _sut;

    public PerformanceStatusMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var overviewDto = new OverviewDto(
            "pak alvin",
            4.2,
            13,
            6);
        var lex = Lexicalization.Create();
        var tp = TemplateProvider.Create();
        _sut = new PerformanceStatusMessage(overviewDto, lex, tp);
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
    public void EmbedComplement_SecondOption_ChangeComplementValue()
    {
        // Arrange
        var option = new Option("second");
        const string expected = "beliau";
        // Act
        _sut.EmbedComplement(option);
        // Assert
        Assert.Equal(expected, _sut.Complement[0]);
    }
}