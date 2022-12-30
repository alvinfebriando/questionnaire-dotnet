﻿using Moq;
using Questionnaire.Application;
using Questionnaire.Application.Message;
using Questionnaire.Application.Topic;
using Questionnaire.Domain.Entities;
using Xunit.Abstractions;

namespace Application.Tests.Topic;

public class OpeningTopicTests
{
    private readonly ITestOutputHelper _output;
    private readonly OpeningTopic _sut;

    public OpeningTopicTests(ITestOutputHelper output)
    {
        _output = output;
        var date = new DateOnly(2022, 12, 26);
        var content = new Content("place", date, "subject", "respondent", "lecturer", 3.5);
        var structure = new Structure();
        var lex = new Mock<ILexicalization>();
        _sut = new OpeningTopic(content, structure, lex.Object);
    }

    [Fact]
    public void Order_NoArgument_ReturnOpeningMessage()
    {
        // Arrange 
        const int expected = 1;
        // Act
        var s = _sut.Order();
        // Assert
        Assert.Equal(expected, s.Count);
        Assert.IsType<OpeningMessage>(s[0]);
        _output.WriteLine(s.ToString());
    }

    [Fact]
    public void Aggregate_()
    {
        // Arrange 
        const string expected = "pada tanggal";
        var expected2 = _sut.Content.Place;
        // Act
        var s = _sut.Aggregate();
        // Assert
        Assert.Contains(expected, s[0]);
        Assert.Contains(expected2, s[0]);
    }
}