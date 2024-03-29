﻿using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using SharedKernel;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class DetailPointMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly DetailPointMessage _sut;

    public DetailPointMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var averagedAnswer = Generator.GenerateAveragedAnswer();
        var dto = new PointDto("pak alvin", averagedAnswer);
        var lex = Lexicalization.Create();
        var tp = TemplateProvider.Create();
        _sut = new DetailPointMessage(dto, lex, tp);
    }

    [Fact]
    public void Lexicalization_NoArgument_ReturnEmbeddedString()
    {
        // Arrange
        var expected = _sut.Data.Answer.Answer.First().SurveyQuestion.Question.Title;
        // Act
        var s = _sut.EntitySlotting();
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
        Assert.Equal(expected, _sut.Complement[1]);
        _output.WriteLine(_sut.Complement[1]);
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
        Assert.Equal(expected, _sut.Complement[1]);
        _output.WriteLine(_sut.Complement[1]);
    }
}