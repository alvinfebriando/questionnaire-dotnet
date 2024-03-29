﻿using Questionnaire.Application.Service.Message;
using Questionnaire.Application.Service.Topic;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using SharedKernel;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Topic;

public class ClosingTopicTests
{
    private readonly ITestOutputHelper _output;
    private readonly ClosingTopic _sut;

    public ClosingTopicTests(ITestOutputHelper output)
    {
        _output = output;
        var point = new Point();
        var content = new Content(
            "",
            new DateOnly(2022, 12, 24),
            "",
            "",
            "",
            1.4,
            0,
            0,
            point);
        var structure = new Structure();
        var lex = Lexicalization.Create();
        var tp = TemplateProvider.Create();
        _sut = new ClosingTopic(
            content,
            structure,
            lex,
            tp);
    }

    [Fact]
    private void Order_1Advice_ReturnMessage()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad",
                "advice"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("bad", QuestionSection.TransparansiNilai);
        _sut.Content.Point.Bad = new List<AveragedAnswer> { averagedAnswer1 };
        // Act
        var messages = _sut.Sort();
        // Assert
        Assert.IsType<AdviceMessage>(messages[0]);
        Assert.NotEmpty(messages[0].Data.Advice);
    }

    [Fact]
    private void Order_2Advice_ReturnMessage()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad",
                "advice"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("bad", QuestionSection.TransparansiNilai);
        var averagedAnswer2 = GenerateAveragedAnswer("bad", QuestionSection.KedisiplinanWaktu);
        _sut.Content.Point.Bad = new List<AveragedAnswer> { averagedAnswer1, averagedAnswer2 };
        // Act
        var messages = _sut.Sort();
        // Assert
        Assert.IsType<AdviceMessage>(messages[0]);
        Assert.IsType<AdviceMessage>(messages[1]);
        Assert.NotEmpty(messages[0].Data.Advice);
        Assert.NotEmpty(messages[1].Data.Advice);
    }

    [Fact]
    private void Order_NoAdvice_ReturnMessage()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "no bad",
                "no advice"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("good", QuestionSection.TransparansiNilai);
        _sut.Content.Point.Min = averagedAnswer1;

        // Act
        var messages = _sut.Sort();

        // Assert
        Assert.IsType<NoAdviceMessage>(messages[0]);
        Assert.NotEmpty(messages[0].Data.Advice);
    }

    [Fact]
    public void Aggregate_1Advice_ReturnString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad",
                "advice"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("bad", QuestionSection.PenguasaanMateri);
        _sut.Content.Point.Bad.Add(averagedAnswer1);
        // Act
        var s = _sut.Aggregate();
        // Assert
    }

    [Fact]
    public void Aggregate_2Advice_ReturnString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad",
                "advice"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("bad", QuestionSection.PenguasaanMateri);
        var averagedAnswer2 = GenerateAveragedAnswer("bad", QuestionSection.TransparansiNilai);
        _sut.Content.Point.Bad.Add(averagedAnswer1);
        _sut.Content.Point.Bad.Add(averagedAnswer2);
        // Act
        var s = _sut.Aggregate();
        // Assert
    }

    [Fact]
    public void Aggregate_3Advice_ReturnString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad",
                "advice"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("bad", QuestionSection.PenguasaanMateri);
        var averagedAnswer2 = GenerateAveragedAnswer("bad", QuestionSection.TransparansiNilai);
        var averagedAnswer3 = GenerateAveragedAnswer("bad", QuestionSection.PenggunaanElearning);
        _sut.Content.Point.Bad.Add(averagedAnswer1);
        _sut.Content.Point.Bad.Add(averagedAnswer2);
        _sut.Content.Point.Bad.Add(averagedAnswer3);
        // Act
        var s = _sut.Aggregate();
        // Assert
    }

    [Fact]
    public void Aggregate_NoAdvice_ReturnString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "no bad",
                "no advice"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("no bad", QuestionSection.PenguasaanMateri);
        _sut.Content.Point.Min = averagedAnswer1;
        // Act
        var s = _sut.Aggregate();
        // Assert
        _output.WriteLine(s[0].Result);
    }

    private static AveragedAnswer GenerateAveragedAnswer(string type, QuestionSection section)
    {
        double score1;
        double score2;
        switch (type)
        {
            case "good":
                score1 = 4.1;
                score2 = 4.3;
                break;
            case "bad":
                score1 = 1.7;
                score2 = 1.5;
                break;
            case "no good":
                score1 = 3.1;
                score2 = 3.3;
                break;
            default:
                score1 = 2.8;
                score2 = 3.0;
                break;
        }

        var question1 = new Question($"{section}-title1", section, $"{section}-advice1");
        var answer1 = new Answer(Guid.NewGuid(), score1, new SurveyQuestion{Question = question1});
        var question2 = new Question($"{section}-title2", section, $"{section}-advice2");
        var answer2 = new Answer(Guid.NewGuid(),score2, new SurveyQuestion{Question = question2});
        var answers = new List<Answer> { answer1, answer2 };
        var averageScore = (score1 + score2) / 2;
        averageScore = Math.Round(averageScore, 2);
        var averagedAnswer = new AveragedAnswer(section, averageScore, answers);
        return averagedAnswer;
    }
}