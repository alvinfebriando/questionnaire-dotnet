using Questionnaire.Application.Rule;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Rule
{
    public class StructureRuleTests
    {
        private readonly ITestOutputHelper _output;
        private readonly StructureRule _sut;

        public StructureRuleTests(ITestOutputHelper output)
        {
            _output = output;
            _sut = new StructureRule();
        }

        [Fact]
        public void Rule_GoodEmptyBadEmpty_ReturnStructure()
        {
            // Arrange
            var p = new Point();
        
            const string expected = "opening";
            var expected2 = new List<string> { "score", "performance" };
            var expected3 = new List<string> { "no good", "no bad" };
            const string expected4 = "no advice";
            // Act
            var s = _sut.Rule(p);
            // Assert
            Assert.Equal(expected, s.Get(0));
            Assert.Contains(s.Get(1), expected2);
            Assert.Contains(s.Get(3), expected3);
            Assert.Equal(expected4, s.Get(5));

            _output.WriteLine(s.ToString());
        }

        [Fact]
        public void Rule_GoodEmptyBadNotEmpty_ReturnStructure()
        {
            // Arrange
            var p = new Point();
            var answer1 = new Answer(1.7,
                new Question("title1", QuestionSection.KedisiplinanWaktu, "advice1"));
            var answer2 = new Answer(1.7,
                new Question("title2", QuestionSection.KedisiplinanWaktu, "2"));
            var answers = new List<Answer> { answer1, answer2 };
            var averagedAnswer = new AveragedAnswer(QuestionSection.KedisiplinanWaktu, 1.7, answers);
            p.Bad.Add(averagedAnswer);

            const string expected = "opening";
            var expected2 = new List<string> { "score", "performance" };
            var expected3 = new List<string> { "no good", "bad" };
            const string expected4 = "advice";
            // Act
            var s = _sut.Rule(p);
            // Assert
            Assert.Equal(expected, s.Get(0));
            Assert.Contains(s.Get(1), expected2);
            Assert.Contains(s.Get(3), expected3);
            Assert.Equal(expected4, s.Get(5));

            _output.WriteLine(s.ToString());
        }
    
        [Fact]
        public void Rule_GoodNotEmptyBadEmpty_ReturnStructure()
        {
            // Arrange
            var p = new Point();
            var answer1 = new Answer(4.1,
                new Question("title1", QuestionSection.KedisiplinanWaktu, "advice1"));
            var answer2 = new Answer(4.1,
                new Question("title2", QuestionSection.KedisiplinanWaktu, "advice2"));
            var answers = new List<Answer> { answer1, answer2 };
            var averagedAnswer = new AveragedAnswer(QuestionSection.KedisiplinanWaktu, 4.1, answers);
            p.Good.Add(averagedAnswer);

            const string expected = "opening";
            var expected2 = new List<string> { "score", "performance" };
            var expected3 = new List<string> { "no bad", "good" };
            const string expected4 = "no advice";
            // Act
            var s = _sut.Rule(p);
            // Assert
            Assert.Equal(expected, s.Get(0));
            Assert.Contains(s.Get(1), expected2);
            Assert.Contains(s.Get(3), expected3);
            Assert.Equal(expected4, s.Get(5));

            _output.WriteLine(s.ToString());
        }
    
        [Fact]
        public void Rule_GoodNotEmptyBadNotEmpty_ReturnStructure()
        {
            // Arrange
            var p = new Point();
            var answer1 = new Answer(4.1,
                new Question("title1", QuestionSection.KedisiplinanWaktu, "advice1"));
            var answer2 = new Answer(4.1,
                new Question("title2", QuestionSection.KedisiplinanWaktu, "advice2"));
            var answer3 = new Answer(1.1,
                new Question("title3", QuestionSection.KedisiplinanWaktu, "advice3"));
            var answer4 = new Answer(1.1,
                new Question("title4", QuestionSection.KedisiplinanWaktu, "advice4"));
            var answers1 = new List<Answer> { answer1, answer2 };
            var answers2 = new List<Answer> { answer3, answer4 };
            var averagedAnswer1 = new AveragedAnswer(QuestionSection.KedisiplinanWaktu, 4.1, answers1);
            var averagedAnswer2 = new AveragedAnswer(QuestionSection.KedisiplinanWaktu, 1.7, answers2);
            p.Good.Add(averagedAnswer1);
            p.Bad.Add(averagedAnswer2);

            const string expected = "opening";
            var expected2 = new List<string> { "score", "performance" };
            var expected3 = new List<string> { "bad", "good" };
            const string expected4 = "advice";
            // Act
            var s = _sut.Rule(p);
            // Assert
            Assert.Equal(expected, s.Get(0));
            Assert.Contains(s.Get(1), expected2);
            Assert.Contains(s.Get(3), expected3);
            Assert.Equal(expected4, s.Get(5));

            _output.WriteLine(s.ToString());
        }
    }
}