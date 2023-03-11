using Questionnaire.Application.Service.Message;
using Questionnaire.Application.Service.Topic;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using SharedKernel;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Topic;

public class PointTopicTests
{
    private readonly ITestOutputHelper _output;
    private readonly PointTopic _sut;

    public PointTopicTests(ITestOutputHelper output)
    {
        _output = output;
        var point = new Point();
        var content = new Content(
            "",
            new DateOnly(2022, 12, 31),
            "",
            "",
            "pak alvin",
            4.1,
            0,
            0,
            point);
        var structure = new Structure();
        var lex = Lexicalization.Create();
        var tp = TemplateProvider.Create();
        _sut = new PointTopic(
            content,
            structure,
            lex,
            tp);
    }

    [Fact]
    public void Order_1Good1BadPoint_ReturnMessages()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good"
            });

        var averagedAnswer1 = GenerateAveragedAnswer("good", QuestionSection.KedisiplinanWaktu);
        var averagedAnswer2 = GenerateAveragedAnswer("bad", QuestionSection.KesempatanBertanya);

        _sut.Content.Point.Good.Add(averagedAnswer1);
        _sut.Content.Point.Bad.Add(averagedAnswer2);
        // Act
        var messages = _sut.Sort();
        // Assert
        Assert.IsType<GoodPointMessage>(messages[0]);
        Assert.IsType<BadPointMessage>(messages[1]);
        Assert.IsType<DetailPointMessage>(messages[2]);
        Assert.IsType<DetailPointMessage>(messages[3]);
    }

    [Fact]
    public void Order_1Bad1Good_ReturnMessages()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "bad"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("good", QuestionSection.KedisiplinanWaktu);
        var averagedAnswer2 = GenerateAveragedAnswer("bad", QuestionSection.KesempatanBertanya);
        _sut.Content.Point.Bad.Add(averagedAnswer2);
        _sut.Content.Point.Good.Add(averagedAnswer1);

        // Act
        var messages = _sut.Sort();

        // Assert
        Assert.IsType<BadPointMessage>(messages[0]);
        Assert.IsType<GoodPointMessage>(messages[1]);
        Assert.IsType<DetailPointMessage>(messages[2]);
        Assert.IsType<DetailPointMessage>(messages[3]);
    }

    [Fact]
    public void Order_0Good1Bad_ReturnMessages()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "no good",
                "bad"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("ordinary", QuestionSection.KedisiplinanWaktu);
        var averagedAnswer2 = GenerateAveragedAnswer("bad", QuestionSection.KesempatanBertanya);
        _sut.Content.Point.Bad.Add(averagedAnswer2);
        _sut.Content.Point.Good.Add(averagedAnswer1);

        // Act
        var messages = _sut.Sort();

        // Assert
        Assert.IsType<NoGoodPointMessage>(messages[0]);
        Assert.IsType<BadPointMessage>(messages[1]);
        Assert.IsType<DetailPointMessage>(messages[2]);
        Assert.IsType<DetailPointMessage>(messages[3]);
    }

    [Fact]
    public void Order_1Good0Bad_ReturnMessages()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "no bad"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("ordinary", QuestionSection.KedisiplinanWaktu);
        var averagedAnswer2 = GenerateAveragedAnswer("good", QuestionSection.KesempatanBertanya);
        _sut.Content.Point.Bad.Add(averagedAnswer1);
        _sut.Content.Point.Good.Add(averagedAnswer2);

        // Act
        var messages = _sut.Sort();

        // Assert
        Assert.IsType<GoodPointMessage>(messages[0]);
        Assert.IsType<NoBadPointMessage>(messages[1]);
        Assert.IsType<DetailPointMessage>(messages[2]);
        Assert.IsType<DetailPointMessage>(messages[3]);
    }

    [Fact]
    public void Order_0Bad0Good_ReturnMessages()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "no bad",
                "no good"
            });
        var averagedAnswer1 = GenerateAveragedAnswer("no bad", QuestionSection.TransparansiNilai);
        var averagedAnswer2 = GenerateAveragedAnswer("no good", QuestionSection.PenguasaanMateri);
        _sut.Content.Point.Good.Add(averagedAnswer1);
        _sut.Content.Point.Bad.Add(averagedAnswer2);
        // Act
        var messages = _sut.Sort();
        // Assert
        Assert.IsType<NoBadPointMessage>(messages[0]);
        Assert.IsType<NoGoodPointMessage>(messages[1]);
        Assert.IsType<DetailPointMessage>(messages[2]);
        Assert.IsType<DetailPointMessage>(messages[3]);
    }

    [Fact]
    public void Aggregate_1Good1Bad_ReturnLexicalizationString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad"
            });
        var option1 = new MessageOption("good", 1);
        var option2 = new MessageOption("bad", 1);
        GenerateOrderOfMessages(option1, option2);

        const int expected = 4;
        // Act
        var s = _sut.Aggregate();

        // Assert
        Assert.Equal(expected, s.Count);
    }

    [Fact]
    public void Aggregate_2Good1Bad_ReturnLexicalizationString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad"
            });
        var option1 = new MessageOption("good", 2);
        var option2 = new MessageOption("bad", 1);
        GenerateOrderOfMessages(option1, option2);

        const int expected = 4;
        // Act
        var s = _sut.Aggregate();

        // Assert
        Assert.Equal(expected, s.Count);
    }

    [Fact]
    public void Aggregate_1Good2Bad_ReturnLexicalizationString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad"
            });
        var option1 = new MessageOption("good", 1);
        var option2 = new MessageOption("bad", 2);
        GenerateOrderOfMessages(option1, option2);

        const int expected = 4;
        // Act
        var s = _sut.Aggregate();

        // Assert
        Assert.Equal(expected, s.Count);
    }

    [Fact]
    public void Aggregate_2Good2Bad_ReturnLexicalizationString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad"
            });
        var option1 = new MessageOption("good", 2);
        var option2 = new MessageOption("bad", 2);
        GenerateOrderOfMessages(option1, option2);

        const int expected = 4;
        // Act
        var s = _sut.Aggregate();

        // Assert
        Assert.Equal(expected, s.Count);
    }

    [Fact]
    public void Aggregate_3Good3Bad_ReturnLexicalizationString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "good",
                "bad"
            });
        var option1 = new MessageOption("good", 3);
        var option2 = new MessageOption("bad", 3);
        GenerateOrderOfMessages(option1, option2);

        const int expected = 4;
        // Act
        var s = _sut.Aggregate();

        // Assert
        Assert.Equal(expected, s.Count);
    }

    [Fact]
    public void Aggregate_0Good0Bad_ReturnLexicalizationString()
    {
        // Arrange
        _sut.Structure.AddRange(
            new List<string>
            {
                "",
                "",
                "",
                "no good",
                "no bad"
            });
        var option1 = new MessageOption("no good", 1);
        var option2 = new MessageOption("no bad", 1);
        GenerateOrderOfMessages(option1, option2);

        const int expected = 4;
        // Act
        var s = _sut.Aggregate();

        // Assert
        Assert.Equal(expected, s.Count);
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
        var answer1 = new Answer(score1, question1);
        var question2 = new Question($"{section}-title2", section, $"{section}-advice2");
        var answer2 = new Answer(score2, question2);
        var answers = new List<Answer> { answer1, answer2 };
        var averageScore = (score1 + score2) / 2;
        averageScore = Math.Round(averageScore, 2);
        var averagedAnswer = new AveragedAnswer(section, averageScore, answers);
        return averagedAnswer;
    }

    private void GenerateOrderOfMessages(
        MessageOption first,
        MessageOption second)
    {
        var averagedAnswer1 = GenerateAveragedAnswer(first.Type, QuestionSection.TransparansiNilai);
        var averagedAnswer2 = GenerateAveragedAnswer(second.Type, QuestionSection.PenguasaanMateri);
        switch (first.Type)
        {
            case "good" when second.Type == "bad":
            {
                for (var i = 0; i < first.Count; i++) _sut.Content.Point.Good.Add(averagedAnswer1);

                _sut.Content.Point.Max = averagedAnswer1;

                for (var i = 0; i < second.Count; i++) _sut.Content.Point.Bad.Add(averagedAnswer2);

                _sut.Content.Point.Min = averagedAnswer2;

                break;
            }
            case "good" when second.Type == "no bad":
            {
                for (var i = 0; i < first.Count; i++) _sut.Content.Point.Good.Add(averagedAnswer1);

                _sut.Content.Point.Max = averagedAnswer1;

                _sut.Content.Point.Min = averagedAnswer2;
                break;
            }
            case "bad" when second.Type == "good":
            {
                for (var i = 0; i < first.Count; i++) _sut.Content.Point.Bad.Add(averagedAnswer1);

                _sut.Content.Point.Min = averagedAnswer1;

                for (var i = 0; i < second.Count; i++) _sut.Content.Point.Good.Add(averagedAnswer2);

                _sut.Content.Point.Max = averagedAnswer2;

                break;
            }
            case "bad" when second.Type == "no good":
            {
                for (var i = 0; i < first.Count; i++) _sut.Content.Point.Bad.Add(averagedAnswer1);

                _sut.Content.Point.Min = averagedAnswer1;

                _sut.Content.Point.Max = averagedAnswer2;
                break;
            }
            case "no good" when second.Type == "bad":
            {
                _sut.Content.Point.Max = averagedAnswer1;
                for (var i = 0; i < second.Count; i++) _sut.Content.Point.Bad.Add(averagedAnswer2);

                _sut.Content.Point.Min = averagedAnswer2;

                break;
            }
            case "no good" when second.Type == "no bad":
                _sut.Content.Point.Max = averagedAnswer1;
                _sut.Content.Point.Min = averagedAnswer2;
                break;
            case "no bad" when second.Type == "good":
            {
                _sut.Content.Point.Min = averagedAnswer1;
                for (var i = 0; i < second.Count; i++) _sut.Content.Point.Good.Add(averagedAnswer2);

                _sut.Content.Point.Max = averagedAnswer2;

                break;
            }
            case "no bad" when second.Type == "no good":
                _sut.Content.Point.Min = averagedAnswer1;
                _sut.Content.Point.Max = averagedAnswer2;
                break;
        }
    }

    private record MessageOption(string Type, int Count);
}